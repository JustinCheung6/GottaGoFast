using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float maxV = 150f;
    [SerializeField] private float accel = 30f;
    [SerializeField] private float decel = 300f;

    //[SerializeField] private float skirtFactor = 0.1f;

    private Vector3 playerVel = new Vector3();
    private Vector3 playerAccel = new Vector3();

    private Vector3 moveAxis = new Vector3();
    private bool moveInput;

    private float horizontalInput;

    private void Start()
    {
        InputManager.s.inSystem.GameInputs.Movement.performed += OnMove;
    }

    private void FixedUpdate()
    {
        //Determine Acceleration based on input
        playerAccel.x = accel * moveAxis.x;
        playerAccel.z = accel * moveAxis.z;

        //Determine Velocity based on Acceleration (X)
        if((Mathf.Sign(playerAccel.x) == Mathf.Sign(playerVel.x) || playerVel.x == 0) && playerAccel.x != 0)
            playerVel.x = Mathf.Clamp(playerVel.x + playerAccel.x * Time.fixedDeltaTime, -maxV, maxV);
        else
        {
            float d = Mathf.Sign(playerVel.x) * decel * Time.fixedDeltaTime;
            playerVel.x = (Mathf.Abs(d) >= Mathf.Abs(playerVel.x)) ? 0 : playerVel.x - d;
        }
        //Determine Velocity based on Acceleration (Z)
        if ((Mathf.Sign(playerAccel.z) == Mathf.Sign(playerVel.z) || playerVel.z == 0) && playerAccel.z != 0)
            playerVel.z = Mathf.Clamp(playerVel.z + playerAccel.z * Time.fixedDeltaTime, -maxV, maxV);
        else
        {
            float d = Mathf.Sign(playerVel.z) * decel * Time.fixedDeltaTime;
            playerVel.z = (Mathf.Abs(d) >= Mathf.Abs(playerVel.z)) ? 0 : playerVel.z - d;
        }

        Debug.Log(playerVel);
        //Move player based on Velocity
        transform.position += playerVel * Time.fixedDeltaTime;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = true;
        Vector2 tmp = context.ReadValue<Vector2>();
        moveAxis.z = (tmp.y == 0) ? 0 : Mathf.Sign(tmp.y);
        moveAxis.x = (tmp.x == 0) ? 0 : Mathf.Sign(tmp.x);
    }
}
