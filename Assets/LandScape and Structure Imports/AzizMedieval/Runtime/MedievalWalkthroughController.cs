using UnityEngine;
using UnityEngine.InputSystem;

namespace AzizMedieval
{
    [RequireComponent(typeof(CharacterController))]
    [DisallowMultipleComponent]
    public sealed class MedievalWalkthroughController : MonoBehaviour
    {
        [Tooltip("Child camera used for pitch rotation.")]
        public Transform view;
        public float walkSpeed = 2.5f;
        public float runSpeed = 4.2f;
        public float mouseSensitivity = 0.10f;
        public float gravity = -18f;
        private CharacterController controller;
        private float verticalSpeed;
        private float pitch;
        private bool looking;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
            if (view == null)
            {
                var camera = GetComponentInChildren<Camera>();
                if (camera != null) view = camera.transform;
            }
        }

        private void Update()
        {
            var keyboard = Keyboard.current;
            var mouse = Mouse.current;
            if (keyboard != null && keyboard.escapeKey.wasPressedThisFrame)
                ReleasePointer();
            if (mouse != null && mouse.rightButton.wasPressedThisFrame)
            {
                looking = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            if (mouse != null && mouse.rightButton.wasReleasedThisFrame)
                ReleasePointer();
            if (looking && mouse != null)
            {
                Vector2 delta = mouse.delta.ReadValue() * mouseSensitivity;
                transform.Rotate(0f, delta.x, 0f, Space.World);
                pitch = Mathf.Clamp(pitch - delta.y, -80f, 80f);
                if (view != null) view.localRotation = Quaternion.Euler(pitch, 0f, 0f);
            }

            Vector2 move = Vector2.zero;
            bool running = false;
            if (keyboard != null)
            {
                if (keyboard.wKey.isPressed || keyboard.zKey.isPressed || keyboard.upArrowKey.isPressed) move.y += 1f;
                if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed) move.y -= 1f;
                if (keyboard.aKey.isPressed || keyboard.qKey.isPressed || keyboard.leftArrowKey.isPressed) move.x -= 1f;
                if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed) move.x += 1f;
                running = keyboard.leftShiftKey.isPressed || keyboard.rightShiftKey.isPressed;
            }
            move = Vector2.ClampMagnitude(move, 1f);
            if (controller.isGrounded && verticalSpeed < 0f) verticalSpeed = -2f;
            verticalSpeed = Mathf.Max(verticalSpeed + gravity * Time.deltaTime, -35f);
            Vector3 velocity = (transform.right * move.x + transform.forward * move.y) * (running ? runSpeed : walkSpeed);
            velocity.y = verticalSpeed;
            controller.Move(velocity * Time.deltaTime);
        }

        private void ReleasePointer()
        {
            looking = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        private void OnDisable() { ReleasePointer(); }
        private void OnApplicationFocus(bool focused) { if (!focused) ReleasePointer(); }
    }
}
