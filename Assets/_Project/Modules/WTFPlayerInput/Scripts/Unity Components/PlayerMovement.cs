using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Trubisko.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 1.0f;
        [SerializeField] private float _rotationSmoothTime = 0.1f;
        [SerializeField] private Transform _camera;

        private CharacterController _characterController;
        private float _turnSmoothVelocity;
        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        public void MovePlayer(float horizontalAxis, float verticalAxis)
        {
            Vector3 direction = new Vector3(horizontalAxis, 0f, verticalAxis).normalized;

            if(direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + _camera.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turnSmoothVelocity, _turnSmoothVelocity);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;                
                _characterController.Move(moveDir.normalized * _speed * Time.deltaTime);
            }
        }
    }
}