using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Game.Scripts.UI;
using UnityEngine.InputSystem;



namespace Game.Scripts.LiveObjects
{
    public class Drone : MonoBehaviour
    {
        private enum Tilt
        {
            NoTilt, Forward, Back, Left, Right
        }

        [SerializeField]
        private Rigidbody _rigidbody;
        [SerializeField]
        private float _speed = 5f;
        private bool _inFlightMode = false;
        [SerializeField]
        private Animator _propAnim;
        [SerializeField]
        private CinemachineVirtualCamera _droneCam;
        [SerializeField]
        private InteractableZone _interactableZone;
        private PlayerControl _input;
        [SerializeField]
        private Player _player;
         

        public static event Action OnEnterFlightMode;
        public static event Action onExitFlightmode;

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += EnterFlightMode;
        }
        void Start()
        {
            _input = new PlayerControl();
            _input.Drone.Esc.performed += Esc_performed;

            
        }

       

        private void EnterFlightMode(InteractableZone zone)
        {
            if (_inFlightMode != true && zone.GetZoneID() == 4) // drone Scene
            {
                _propAnim.SetTrigger("StartProps");
                _droneCam.Priority = 11;
                _inFlightMode = true;
                OnEnterFlightMode?.Invoke();
                UIManager.Instance.DroneView(true);
                _interactableZone.CompleteTask(4);
               
            }
        }

        private void ExitFlightMode()
        {            
            _droneCam.Priority = 9;
            _inFlightMode = false;
            UIManager.Instance.DroneView(false);
            _player.enabled = true;


        }

        private void Update()
        {
            if (_inFlightMode)
            {
                CalculateTilt();
                CalculateMovementUpdate();
                _input.Drone.Enable();
                _player.enabled = false;
            }

            //    if (Input.GetKeyDown(KeyCode.Escape))
            //    {
            //       _inFlightMode = false;
            //       onExitFlightmode?.Invoke();
            //      ExitFlightMode();
            //  }
            //   }
        }
        private void Esc_performed(InputAction.CallbackContext obj)
        {
            if (_inFlightMode)
            {
                _inFlightMode = false;
                onExitFlightmode?.Invoke();
                ExitFlightMode();
            }
            
        }

        private void FixedUpdate()
        {
            _rigidbody.AddForce(transform.up * (9.81f), ForceMode.Acceleration);
            if (_inFlightMode)
                CalculateMovementFixedUpdate();
        }

        private void CalculateMovementUpdate()
        {
            //  if (Input.GetKey(KeyCode.LeftArrow))
            //  {
            //     var tempRot = transform.localRotation.eulerAngles;
            //     tempRot.y = _speed / 3;
            //     transform.localRotation = Quaternion.Euler(tempRot);
            // }
            // if (Input.GetKey(KeyCode.RightArrow))
            // {
            //     var tempRot = transform.localRotation.eulerAngles;
            //     tempRot.y = _speed / 3;
            //    transform.localRotation = Quaternion.Euler(tempRot);
            // }
            var tempRot = transform.localRotation.eulerAngles;
               tempRot.y -= _input.Drone.Roate.ReadValue<float>();
            transform.localRotation = Quaternion.Euler(tempRot);
        }

        private void CalculateMovementFixedUpdate()
        {

            //  if (Input.GetKey(KeyCode.Space))
            //  {
            //      _rigidbody.AddForce(transform.up * _speed, ForceMode.Acceleration);
            //  }
            //  if (Input.GetKey(KeyCode.V))
            //  {
            //      _rigidbody.AddForce(-transform.up * _speed, ForceMode.Acceleration);
            //  }
            var direction = _input.Drone.UpDown.ReadValue<float>();
            _rigidbody.AddForce(transform.up * direction * _speed, ForceMode.Acceleration);
        }

        private void CalculateTilt()
        {
            // if (Input.GetKey(KeyCode.A)) 
            //     transform.rotation = Quaternion.Euler(00, transform.localRotation.eulerAngles.y, 30);
            // else if (Input.GetKey(KeyCode.D))
            //     transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, -30);
            // else if (Input.GetKey(KeyCode.W))
            //     transform.rotation = Quaternion.Euler(30, transform.localRotation.eulerAngles.y, 0);
            // else if (Input.GetKey(KeyCode.S))
            //     transform.rotation = Quaternion.Euler(-30, transform.localRotation.eulerAngles.y, 0);
            // else 
            //     transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, 0);

            var move = _input.Drone.Movement.ReadValue<float>();
            transform.rotation = Quaternion.Euler(move, transform.localRotation.eulerAngles.y, 0);

        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterFlightMode;
        }
    }
}
