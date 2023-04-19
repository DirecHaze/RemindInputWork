using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine.InputSystem;


namespace Game.Scripts.LiveObjects
{
    public class Laptop : MonoBehaviour
    {
        [SerializeField]
        private Slider _progressBar;
        [SerializeField]
        private int _hackTime = 5;
        private bool _hacked = false;
        [SerializeField]
        private CinemachineVirtualCamera[] _cameras;
        private int _activeCamera = 0;
        [SerializeField]
        private InteractableZone _interactableZone;
        private PlayerControl _input;

        public static event Action onHackComplete;
        public static event Action onHackEnded;

        private void OnEnable()
        {
            InteractableZone.onHoldStarted += InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded += InteractableZone_onHoldEnded;
        }
         void Start()
        {
            _input = new PlayerControl();
            _input.Player.Enable();
            _input.Player.Esc.performed += Esc_performed;
        }

     

        //  private void Update()
        //  {
        //      if (_hacked == true)
        //     {
        //        if (Input.GetKeyDown(KeyCode.E))
        //        {
        //           var previous = _activeCamera;
        //           _activeCamera++;


        //           if (_activeCamera >= _cameras.Length)
        //              _activeCamera = 0;


        //         _cameras[_activeCamera].Priority = 11;
        //        _cameras[previous].Priority = 9;
        //    }

        //    if (Input.GetKeyDown(KeyCode.Escape))
        //    {
        //        _hacked = false;
        //       onHackEnded?.Invoke();
        //       ResetCameras();
        //   }
        //  }
        //}

        void ResetCameras()
        {
            foreach (var cam in _cameras)
            {
                cam.Priority = 9;
            }
        }

        private void InteractableZone_onHoldStarted(int zoneID)
        {
            if (zoneID == 3 && _hacked == false) //Hacking terminal
            {
                _progressBar.gameObject.SetActive(true);
                StartCoroutine(HackingRoutine());
                onHackComplete?.Invoke();
            }
            if (zoneID == 3 && _hacked == true)
            {
                var previous = _activeCamera;
                _activeCamera++;


                if (_activeCamera >= _cameras.Length)
                    _activeCamera = 0;


                _cameras[_activeCamera].Priority = 11;
                _cameras[previous].Priority = 9;

            }
        }
        

        private void InteractableZone_onHoldEnded(int zoneID)
        {
            if (zoneID == 3) //Hacking terminal
            {
                if (_hacked == true)
                    return;

                StopAllCoroutines();
                _progressBar.gameObject.SetActive(false);
                _progressBar.value = 0;
                onHackEnded?.Invoke();
            }
        }
        private void Esc_performed(InputAction.CallbackContext obj)
        {
            _hacked = false;
            onHackEnded?.Invoke();
            ResetCameras();
        }


        IEnumerator HackingRoutine()
        {
            while (_progressBar.value < 1)
            {
                _progressBar.value += Time.deltaTime / _hackTime;
                yield return new WaitForEndOfFrame();
            }

            //successfully hacked
            _hacked = true;
            _interactableZone.CompleteTask(3);

            //hide progress bar
            _progressBar.gameObject.SetActive(false);

            //enable Vcam1
            _cameras[0].Priority = 11;
        }
        
        private void OnDisable()
        {
            InteractableZone.onHoldStarted -= InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded -= InteractableZone_onHoldEnded;
        }
    }

}

