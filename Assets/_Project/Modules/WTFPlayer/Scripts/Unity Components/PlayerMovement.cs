using System;
using UnityEngine;

namespace WTF.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 1.0f;
        [SerializeField] private float _jumpheight = 2.0f;
        [SerializeField] private float _smoothTurnStep = 0.4f;
        [SerializeField] private Transform _camera;
        [SerializeField] private LayerMask _groundLayer;

        private CharacterController _characterController;
        private float _turnSmoothVelocity;
        private bool _isGrounded;
        private Vector3 _velocity;
        private Transform _groundChecker;
        private float _gravity = -9.8f;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
            CreateGroundChecker();
        }

        private void CreateGroundChecker()
        {
            _groundChecker = new GameObject("Ground Checker").transform;
            _groundChecker.SetParent(transform);
            Collider collider = GetComponent<Collider>();
            Vector3 groundCheckerPos = collider.bounds.center;
            groundCheckerPos.y = collider.bounds.min.y;
            _groundChecker.position = groundCheckerPos;
        }

        public void MovePlayer(float horizontalAxis, float verticalAxis, bool jump)
        {
            Move(horizontalAxis, verticalAxis);
            ApplyGravity(jump);
        }

        private void Move(float horizontalAxis, float verticalAxis)
        {
            Vector3 move = transform.right * horizontalAxis + transform.forward * verticalAxis;
            _characterController.Move(move * _speed * Time.deltaTime);
        }

        private void ApplyGravity(bool jump)
        {
            _isGrounded = Physics.CheckSphere(_groundChecker.position, 0.1f, _groundLayer, QueryTriggerInteraction.Ignore);
            if (_isGrounded && _velocity.y < 0)
                _velocity.y = 0f;

            if (jump && _isGrounded)
                _velocity.y += Mathf.Sqrt(_jumpheight * -2f * _gravity);

            _velocity.y += _gravity * Time.deltaTime;

            _characterController.Move(_velocity * Time.deltaTime);
        }

        private Vector3 CalculateDirectionBasedOnCamera(Vector3 direction)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + _camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turnSmoothVelocity, _smoothTurnStep);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            return Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        }
    }
}