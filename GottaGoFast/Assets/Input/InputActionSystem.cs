// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputActionSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActionSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActionSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionSystem"",
    ""maps"": [
        {
            ""name"": ""GameInputs"",
            ""id"": ""9520e326-83ee-468c-9329-b7b37ad5aea2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d37f21f1-ebc7-466a-89d8-73866c395028"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseMovement"",
                    ""type"": ""Value"",
                    ""id"": ""7e09ea01-ff8b-4500-8b67-bff12b47b48c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""738855d3-fa99-468d-8a1b-9cce2bdb2fc3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""55c876b5-d340-4b74-8cd4-744bd274b50b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1176a4be-6aba-4409-bb08-b6de11651fdc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6a053f7c-806f-40c7-8025-3f35d15edf99"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6fd24137-cd3f-439a-8b78-4cdb023d11b1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""395b2cb0-bbb5-4c71-ba6e-c8927a1cfb8d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""af3165f1-c2bf-4635-a4e6-187448bcd289"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1000)"",
                    ""groups"": """",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d9b99b52-50c9-4383-9b0c-396ea3a5b19c"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1000)"",
                    ""groups"": """",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4a492bb6-4411-494f-845c-478326518ea5"",
                    ""path"": ""<VirtualMouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1000)"",
                    ""groups"": """",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""95443224-b289-4976-a322-c4788226cc8c"",
                    ""path"": ""<VirtualMouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1000)"",
                    ""groups"": """",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameInputs
        m_GameInputs = asset.FindActionMap("GameInputs", throwIfNotFound: true);
        m_GameInputs_Movement = m_GameInputs.FindAction("Movement", throwIfNotFound: true);
        m_GameInputs_MouseMovement = m_GameInputs.FindAction("MouseMovement", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // GameInputs
    private readonly InputActionMap m_GameInputs;
    private IGameInputsActions m_GameInputsActionsCallbackInterface;
    private readonly InputAction m_GameInputs_Movement;
    private readonly InputAction m_GameInputs_MouseMovement;
    public struct GameInputsActions
    {
        private @InputActionSystem m_Wrapper;
        public GameInputsActions(@InputActionSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GameInputs_Movement;
        public InputAction @MouseMovement => m_Wrapper.m_GameInputs_MouseMovement;
        public InputActionMap Get() { return m_Wrapper.m_GameInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameInputsActions set) { return set.Get(); }
        public void SetCallbacks(IGameInputsActions instance)
        {
            if (m_Wrapper.m_GameInputsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GameInputsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameInputsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameInputsActionsCallbackInterface.OnMovement;
                @MouseMovement.started -= m_Wrapper.m_GameInputsActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.performed -= m_Wrapper.m_GameInputsActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.canceled -= m_Wrapper.m_GameInputsActionsCallbackInterface.OnMouseMovement;
            }
            m_Wrapper.m_GameInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseMovement.started += instance.OnMouseMovement;
                @MouseMovement.performed += instance.OnMouseMovement;
                @MouseMovement.canceled += instance.OnMouseMovement;
            }
        }
    }
    public GameInputsActions @GameInputs => new GameInputsActions(this);
    public interface IGameInputsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseMovement(InputAction.CallbackContext context);
    }
}
