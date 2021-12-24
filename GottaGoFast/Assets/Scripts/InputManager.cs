using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager s = null;

    public InputActionSystem inSystem = null;

    private void Awake()
    {
        #region Initialize Singleton
        if (s == null)
            s = this;
        else
            Debug.Log("Multiple InputManager scripts");
        #endregion

        inSystem = new InputActionSystem();

        #region Activate InputEvents

        inSystem.GameInputs.Movement.Enable();
        inSystem.GameInputs.MouseMovement.Enable();
        
        #endregion
    }
}
