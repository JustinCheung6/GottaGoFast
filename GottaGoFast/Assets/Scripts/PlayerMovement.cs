using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float maxV = 150f;
    [SerializeField] private float minA = 5f;
    [SerializeField] private float maxA = 50f;

    [SerializeField] private float increaseA = 5f;
    [SerializeField] private float decreaseA = 50f;

    private float playerVel;
    private float playerAccel;

    private float verticalInput = 0;
    private float horizontalInput;

    private void Start()
    {
        InputManager.s.inSystem.GameInputs.Movement.performed += OnMove;
    }

    private void FixedUpdate()
    {
        if(verticalInput != 0)
        {
            if(playerAccel == 0)
                playerAccel = minA * Mathf.Sign(verticalInput);
        }
        if (InputManager.s.inSystem.GameInputs.Movement.enabled)
        {

        }

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        Debug.Log(moveInput);
    }
}
