using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class Crate : MonoBehaviour
    {
        [SerializeField] private float _punchDelay;
        [SerializeField] private GameObject _wholeCrate, _brokenCrate;
        [SerializeField] private Rigidbody[] _pieces;
        [SerializeField] private BoxCollider _crateCollider;
        [SerializeField] private InteractableZone _interactableZone;
        private bool _isReadyToBreak = false;
        private bool _holdActionPerformed = false;
        private PlayerControl _input;
        

        private List<Rigidbody> _brakeOff = new List<Rigidbody>();

        private void OnEnable()
        {
           //InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
            InteractableZone.onHoldStarted += InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded += InteractableZone_onHoldEnded;
            

        }

       

        private void Start()
        {
            _brakeOff.AddRange(_pieces);
            _input = new PlayerControl();
            _input.Crate.Tap.performed += Tap_performed;
           

        }



        //   private void InteractableZone_onZoneInteractionComplete(InteractableZone zone)
        //  {

        //    if (_isReadyToBreak == false && _brakeOff.Count > 0)
        //  {
        //    _wholeCrate.SetActive(false);
        //  _brokenCrate.SetActive(true);
        //_isReadyToBreak = true;
        //}

        //if (_isReadyToBreak && zone.GetZoneID() == 6 ) //Crate zone            
        //{
        //  if (_brakeOff.Count > 0)
        //{
        //  BreakPart();
        //StartCoroutine(PunchDelay());

        //}
        //else if (_brakeOff.Count == 0)
        //{
        //  _isReadyToBreak = false;
        //_crateCollider.enabled = false;
        //_interactableZone.CompleteTask(6);
        //Debug.Log("Completely Busted");
        //}
        //}
        //}
        private void InteractableZone_onHoldStarted(int zone)
        {
            if (_isReadyToBreak == false && _brakeOff.Count > 0 )
            {
                _wholeCrate.SetActive(false);
                _brokenCrate.SetActive(true);
                _isReadyToBreak = true;
               
            }

            if (_isReadyToBreak && zone == 6) //Crate zone            
            {
                if (_brakeOff.Count >= 2)
                {
                    _holdActionPerformed = true;
                    
                    StartCoroutine(PunchDelay());
                    
                }
                if(_brakeOff.Count == 1)
                {
                    BreakPart();
                    StartCoroutine(PunchDelay());
                }
                else if (_brakeOff.Count == 0)
                {
                    
                    _isReadyToBreak = false;
                    _crateCollider.enabled = false;
                    _interactableZone.CompleteTask(6);
                    Debug.Log("Completely Busted");
                }
                
            }
        }
        private void InteractableZone_onHoldEnded(int zone)
        {
            _holdActionPerformed = false;
            _isReadyToBreak = false;
            if (zone <= 6)
            {
                _isReadyToBreak = false;
            }
            
           
        }
        private void Tap_performed(InputAction.CallbackContext obj)
        {
          if (_isReadyToBreak == false && _brakeOff.Count > 0)
            {
                _wholeCrate.SetActive(false);
                _brokenCrate.SetActive(true);
                _isReadyToBreak = true;
            }
           
            if (_isReadyToBreak == true) //Crate zone            
            {
                if (_brakeOff.Count > 0)
                {
                    BreakPart();
                    StartCoroutine(PunchDelay());
                    Debug.Log("1 drop");

                }
                else if (_brakeOff.Count == 0)
                {
                    _isReadyToBreak = false;
                    _crateCollider.enabled = false;
                    _interactableZone.CompleteTask(6);
                    _input.Crate.Disable();
                    Debug.Log("Completely Busted");
                }

            }
        }



        void Update()
        {



            if (_holdActionPerformed == true)
            {
                int rng = Random.Range(0, _brakeOff.Count);
                _brakeOff[rng].constraints = RigidbodyConstraints.None;
                _brakeOff[rng].AddForce(new Vector3(1f, 1f, 1f), ForceMode.Force);
                _brakeOff.Remove(_brakeOff[rng]);
                BreakPart();
                _holdActionPerformed = false;
                Debug.Log("2 drop");
            }
            if (_brakeOff.Count == 0)
            {
                _isReadyToBreak = false;
                _crateCollider.enabled = false;
                _interactableZone.CompleteTask(6);
                _input.Crate.Disable();
                Debug.Log("Completely Busted");
            }




        }



        public void BreakPart()
        {
            int rng = Random.Range(0, _brakeOff.Count);
            _brakeOff[rng].constraints = RigidbodyConstraints.None;
            _brakeOff[rng].AddForce(new Vector3(1f, 1f, 1f), ForceMode.Force);
            _brakeOff.Remove(_brakeOff[rng]);
           
            
        }
       
               
        



        IEnumerator PunchDelay()
        {
            float delayTimer = 0;
            while (delayTimer < _punchDelay)
            {
                yield return new WaitForEndOfFrame();
                delayTimer += Time.deltaTime;
                
            }

            _interactableZone.ResetAction(6);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                _input.Crate.Enable();
            }
        }

        private void OnDisable()
        {
            //InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
            InteractableZone.onHoldStarted -= InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded -= InteractableZone_onHoldEnded;
        }
    }
}
