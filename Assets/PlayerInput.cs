//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""BaseMap"",
            ""id"": ""6b9387b5-df49-4c62-ad17-cc1e2022ff83"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""54804df5-e354-45b8-bf3c-8702155384c8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""375f2adf-9d0b-4382-b38d-7571ac1a21c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraVertical"",
                    ""type"": ""Value"",
                    ""id"": ""0c8f4ed0-22ce-41ca-97d6-6f79a9291b9e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CameraHorizontal"",
                    ""type"": ""Value"",
                    ""id"": ""a2fea3bd-d5b0-49cb-8a2e-a4f024c60a6b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MainInteraction"",
                    ""type"": ""Button"",
                    ""id"": ""f4476375-e6c9-40d8-ac8d-f572479a7cc9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2bb52560-48d7-45ae-a4e9-fb790bc5e29a"",
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
                    ""id"": ""5e66a6bd-4bf0-4987-9f9d-232f525699c0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9768a633-e3f7-4f79-a751-8566d3fda35e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4aa3f480-4aca-404b-bd0d-01f8dbe26c12"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4a8c1fc1-9342-4317-b852-4e689edeb375"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1079df94-07d8-4634-a745-df9693374728"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de840336-a552-4df7-a3ad-549e0d3acb2a"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""CameraVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1113d33b-1404-4958-b914-8b991671d87c"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""CameraHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84f5e30e-4aec-487a-b0f2-df9ecd22661a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MainInteraction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseKeyboard"",
            ""bindingGroup"": ""MouseKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // BaseMap
        m_BaseMap = asset.FindActionMap("BaseMap", throwIfNotFound: true);
        m_BaseMap_Movement = m_BaseMap.FindAction("Movement", throwIfNotFound: true);
        m_BaseMap_Jump = m_BaseMap.FindAction("Jump", throwIfNotFound: true);
        m_BaseMap_CameraVertical = m_BaseMap.FindAction("CameraVertical", throwIfNotFound: true);
        m_BaseMap_CameraHorizontal = m_BaseMap.FindAction("CameraHorizontal", throwIfNotFound: true);
        m_BaseMap_MainInteraction = m_BaseMap.FindAction("MainInteraction", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // BaseMap
    private readonly InputActionMap m_BaseMap;
    private List<IBaseMapActions> m_BaseMapActionsCallbackInterfaces = new List<IBaseMapActions>();
    private readonly InputAction m_BaseMap_Movement;
    private readonly InputAction m_BaseMap_Jump;
    private readonly InputAction m_BaseMap_CameraVertical;
    private readonly InputAction m_BaseMap_CameraHorizontal;
    private readonly InputAction m_BaseMap_MainInteraction;
    public struct BaseMapActions
    {
        private @PlayerInput m_Wrapper;
        public BaseMapActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_BaseMap_Movement;
        public InputAction @Jump => m_Wrapper.m_BaseMap_Jump;
        public InputAction @CameraVertical => m_Wrapper.m_BaseMap_CameraVertical;
        public InputAction @CameraHorizontal => m_Wrapper.m_BaseMap_CameraHorizontal;
        public InputAction @MainInteraction => m_Wrapper.m_BaseMap_MainInteraction;
        public InputActionMap Get() { return m_Wrapper.m_BaseMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BaseMapActions set) { return set.Get(); }
        public void AddCallbacks(IBaseMapActions instance)
        {
            if (instance == null || m_Wrapper.m_BaseMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BaseMapActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @CameraVertical.started += instance.OnCameraVertical;
            @CameraVertical.performed += instance.OnCameraVertical;
            @CameraVertical.canceled += instance.OnCameraVertical;
            @CameraHorizontal.started += instance.OnCameraHorizontal;
            @CameraHorizontal.performed += instance.OnCameraHorizontal;
            @CameraHorizontal.canceled += instance.OnCameraHorizontal;
            @MainInteraction.started += instance.OnMainInteraction;
            @MainInteraction.performed += instance.OnMainInteraction;
            @MainInteraction.canceled += instance.OnMainInteraction;
        }

        private void UnregisterCallbacks(IBaseMapActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @CameraVertical.started -= instance.OnCameraVertical;
            @CameraVertical.performed -= instance.OnCameraVertical;
            @CameraVertical.canceled -= instance.OnCameraVertical;
            @CameraHorizontal.started -= instance.OnCameraHorizontal;
            @CameraHorizontal.performed -= instance.OnCameraHorizontal;
            @CameraHorizontal.canceled -= instance.OnCameraHorizontal;
            @MainInteraction.started -= instance.OnMainInteraction;
            @MainInteraction.performed -= instance.OnMainInteraction;
            @MainInteraction.canceled -= instance.OnMainInteraction;
        }

        public void RemoveCallbacks(IBaseMapActions instance)
        {
            if (m_Wrapper.m_BaseMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBaseMapActions instance)
        {
            foreach (var item in m_Wrapper.m_BaseMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BaseMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BaseMapActions @BaseMap => new BaseMapActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseKeyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    public interface IBaseMapActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCameraVertical(InputAction.CallbackContext context);
        void OnCameraHorizontal(InputAction.CallbackContext context);
        void OnMainInteraction(InputAction.CallbackContext context);
    }
}
