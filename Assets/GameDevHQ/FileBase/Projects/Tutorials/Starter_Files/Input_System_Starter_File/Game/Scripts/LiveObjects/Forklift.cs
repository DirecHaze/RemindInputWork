using System;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class Forklift : MonoBehaviour
    {
        [SerializeField]
        private GameObject _lift, _steeringWheel, _leftWheel, _rightWheel, _rearWheels;
        [SerializeField]
        private Vector3 _liftLowerLimit, _liftUpperLimit;
        [SerializeField]
        private float _speed = 5f, _liftSpeed = 1f;
        [SerializeField]
        private CinemachineVirtualCamera _forkliftCam;
        [SerializeField]
        private GameObject _driverModel;
        private bool _inDriveMode = false;
        [SerializeField]
        private InteractableZone _interactableZone;
        private PlayerControl _input;
        [SerializeField]
        private Player _player;
        private bool _liftRoutineUp = false;
        private bool _liftRoutineDown = false;
        

        public static event Action onDriveModeEntered;
        public static event Action onDriveModeExited;

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += EnterDriveMode;
        }
        void Start()
        {
            _input = new PlayerControl();
            _input.ForkLift.LiftControlUp.performed += LiftControlUp_performed;
            _input.ForkLift.LiftControlDown.performed += LiftControlDown_performed;
            _input.ForkLift.LiftControlUp.canceled += LiftControlUp_canceled;
            _input.ForkLift.LiftControlDown.canceled += LiftControlDown_canceled;
            _input.ForkLift.Esc.performed += Esc_performed;

        }

      

        private void EnterDriveMode(InteractableZone zone)
        {
            if (_inDriveMode !=true && zone.GetZoneID() == 5) //Enter ForkLift
            {
                _inDriveMode = true;
                _forkliftCam.Priority = 11;
                _driverModel.SetActive(true);
                onDriveModeEntered?.Invoke();
                _interactableZone.CompleteTask(5);
                _input.ForkLift.Enable();
                _player.enabled = false;

            }
        }

        private void ExitDriveMode()
        {
            _forkliftCam.Priority = 8;            
            _driverModel.SetActive(false);
            onDriveModeExited?.Invoke();
            _input.ForkLift.Disable();
            _player.enabled = true;

            
        }

        private void Update()
        {
            if (_inDriveMode == true)
            {
                //LiftControls();
                CalcutateMovement();
               // if (Input.GetKeyDown(KeyCode.Escape))
                 //   ExitDriveMode();
            }
            if(_liftRoutineUp == true)
            {
                LiftUpRoutine();
            }
            if(_liftRoutineDown == true)
            {
                LiftDownRoutine();
            }
            if(_inDriveMode == false)
            {
                ExitDriveMode();
            }

        }
        private void Esc_performed(InputAction.CallbackContext obj)
        {
            _inDriveMode = false;

        }

        private void CalcutateMovement()
        {
            // float h = Input.GetAxisRaw("Horizontal");
            // float v = Input.GetAxisRaw("Vertical");
            var h = _input.ForkLift.Roate.ReadValue<float>();
            var v = _input.ForkLift.Movement.ReadValue<float>();
            
            var direction = new Vector3(0, 0, v);
            var velocity = direction * _speed;

            transform.Translate(velocity * Time.deltaTime);

            if (Mathf.Abs(v) > 0)
            {
                var tempRot = transform.rotation.eulerAngles;
                tempRot.y += h * _speed / 2;
                transform.rotation = Quaternion.Euler(tempRot);
            }
        }

       // private void LiftControls()
        //{
          //  if (Input.GetKey(KeyCode.R))
            //    LiftUpRoutine();
            //else if (Input.GetKey(KeyCode.T))
              //  LiftDownRoutine();
       // }
        private void LiftControlUp_performed(InputAction.CallbackContext obj)
        {
            _liftRoutineUp = true;
        }
        private void LiftControlUp_canceled(InputAction.CallbackContext obj)
        {
            _liftRoutineUp = false;
        }

        private void LiftControlDown_performed(InputAction.CallbackContext obj)
        {
            _liftRoutineDown = true;
        }
        private void LiftControlDown_canceled(InputAction.CallbackContext obj)
        {
            _liftRoutineDown = false;
        }

        private void LiftUpRoutine()
        {
            if (_lift.transform.localPosition.y < _liftUpperLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y += Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y >= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftUpperLimit;
        }

        private void LiftDownRoutine()
        {
            if (_lift.transform.localPosition.y > _liftLowerLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y -= Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y <= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftLowerLimit;
        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterDriveMode;
        }

    }
}