using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        InputManager.s.inSystem.GameInputs.MouseMovement.performed += CameraMove;
    }

    private void CameraMove(InputAction.CallbackContext context)
    {
        Debug.Log(context);
    }
}
