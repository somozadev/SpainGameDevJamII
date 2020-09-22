// GENERATED AUTOMATICALLY FROM 'Assets/PlayerMovementActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovementActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovementActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovementActions"",
    ""maps"": [
        {
            ""name"": ""Player_Fighting"",
            ""id"": ""a37a27b5-9e31-402a-8373-772cd7d27ab6"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""238f083b-6e76-4c3c-9062-e37ce28029fc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""210636d4-c122-42cc-a057-e30de26aeb54"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""0333225d-0b15-4809-a559-471af5ec80a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""fd36179e-6c44-4c04-88bf-446b15386989"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseTool"",
                    ""type"": ""Button"",
                    ""id"": ""fbec0ae0-207f-465e-a7f9-8f60723528f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1cc4b7c7-73d1-431d-a5ac-c4988fc3426d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be43c8f9-e7be-4811-80dd-729303d725fa"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea65cffc-40fc-443b-9687-b54c6d7c040b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5136a1b4-2823-4028-abd4-cbc89721f373"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bf35d58-feb7-401c-9398-7ac745225ac2"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player_UI"",
            ""id"": ""a2454913-06f8-4377-b647-b25f5d5c0197"",
            ""actions"": [
                {
                    ""name"": ""ClosePauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""427031fd-c970-40a4-be02-219ac52fcf8e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""4e495242-31ef-4f03-80fb-76e901884bc5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""eca02daf-5abd-4212-89e1-b90cadc67fb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""7f863c58-f67b-40c0-87e9-3b6403bb9751"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6ad6f8d8-4235-4497-b6cb-fdc5ed1b16e8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""18c5beab-054b-4405-93d1-e005127fe088"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""63fa969b-c0f6-49bf-a676-be8de2f932bb"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""ClosePauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6328dfa-5f6d-4029-959f-5fb74d93df82"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ClosePauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad Right Stick"",
                    ""id"": ""9f25a524-9538-4588-b6e8-0c38ffc0cd27"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""752ffea8-f3ff-459b-a6c5-d96a8ab43faf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fc2663fa-cff1-4a97-870f-72c2f60fff7c"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""538e9420-8f1f-42bb-9e98-adff50b782fd"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e442f164-ad8e-49cd-bd6a-0f8741ae8138"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Left Stick"",
                    ""id"": ""959bc77d-4f6d-4a5d-ac10-6eee7937a218"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c1ddff52-f194-40dc-99ce-102db4b78f03"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6e9a30ea-aff0-484e-ac6f-53017e1e921e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3ff41d81-70e2-471c-a716-ad65c2b39412"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d4cd5e31-4c5d-4f41-b972-d26d929bc430"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3ceb4540-e529-4854-a717-f11dceefe970"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""f1ee5ec1-1c5c-45fa-bf38-a8046b7dbdf2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d39127a4-e96b-4bbb-a7ab-cb646dc8019b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7dfb36c5-3deb-4729-bc68-5b6000149b79"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e4b2cd46-ce7d-4fd3-b052-49e4111fa286"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7e36c650-7ad4-4231-b87a-f97ff1121f2c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""d7de59cd-3b15-4588-9a7b-03c92d920c35"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ba2cd407-2b1f-4797-bb2a-f5a8cc04ee7b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bb4f4f16-3965-47ce-b2d8-62b4062f832d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5d045b2d-b97c-4a3b-bee6-66305ea30af9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7f1ac01d-aa2f-4d92-af24-76e28346322c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fe7d9468-a6c8-42a8-b8cd-ae811c47af77"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6251fe4d-07b6-417a-b74e-d8065a2afd16"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a53d75c-b4f0-405a-b439-d75b22be5967"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52d91ce2-cf76-4ea1-9b5f-d5015dba88c7"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touchscreen"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a96fc38c-0ccd-4ecb-8470-4d678c6241e1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Left Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23d1258b-9d89-4ab2-a45a-8b853a5e77d4"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touchscreen"",
                    ""action"": ""Left Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player_Fighting
        m_Player_Fighting = asset.FindActionMap("Player_Fighting", throwIfNotFound: true);
        m_Player_Fighting_Movement = m_Player_Fighting.FindAction("Movement", throwIfNotFound: true);
        m_Player_Fighting_Rotate = m_Player_Fighting.FindAction("Rotate", throwIfNotFound: true);
        m_Player_Fighting_Interact = m_Player_Fighting.FindAction("Interact", throwIfNotFound: true);
        m_Player_Fighting_Drop = m_Player_Fighting.FindAction("Drop", throwIfNotFound: true);
        m_Player_Fighting_UseTool = m_Player_Fighting.FindAction("UseTool", throwIfNotFound: true);
        // Player_UI
        m_Player_UI = asset.FindActionMap("Player_UI", throwIfNotFound: true);
        m_Player_UI_ClosePauseMenu = m_Player_UI.FindAction("ClosePauseMenu", throwIfNotFound: true);
        m_Player_UI_Navigate = m_Player_UI.FindAction("Navigate", throwIfNotFound: true);
        m_Player_UI_Submit = m_Player_UI.FindAction("Submit", throwIfNotFound: true);
        m_Player_UI_Cancel = m_Player_UI.FindAction("Cancel", throwIfNotFound: true);
        m_Player_UI_Point = m_Player_UI.FindAction("Point", throwIfNotFound: true);
        m_Player_UI_LeftClick = m_Player_UI.FindAction("Left Click", throwIfNotFound: true);
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

    // Player_Fighting
    private readonly InputActionMap m_Player_Fighting;
    private IPlayer_FightingActions m_Player_FightingActionsCallbackInterface;
    private readonly InputAction m_Player_Fighting_Movement;
    private readonly InputAction m_Player_Fighting_Rotate;
    private readonly InputAction m_Player_Fighting_Interact;
    private readonly InputAction m_Player_Fighting_Drop;
    private readonly InputAction m_Player_Fighting_UseTool;
    public struct Player_FightingActions
    {
        private @PlayerMovementActions m_Wrapper;
        public Player_FightingActions(@PlayerMovementActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Fighting_Movement;
        public InputAction @Rotate => m_Wrapper.m_Player_Fighting_Rotate;
        public InputAction @Interact => m_Wrapper.m_Player_Fighting_Interact;
        public InputAction @Drop => m_Wrapper.m_Player_Fighting_Drop;
        public InputAction @UseTool => m_Wrapper.m_Player_Fighting_UseTool;
        public InputActionMap Get() { return m_Wrapper.m_Player_Fighting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_FightingActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_FightingActions instance)
        {
            if (m_Wrapper.m_Player_FightingActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnMovement;
                @Rotate.started -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnRotate;
                @Interact.started -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnInteract;
                @Drop.started -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnDrop;
                @UseTool.started -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnUseTool;
                @UseTool.performed -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnUseTool;
                @UseTool.canceled -= m_Wrapper.m_Player_FightingActionsCallbackInterface.OnUseTool;
            }
            m_Wrapper.m_Player_FightingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
                @UseTool.started += instance.OnUseTool;
                @UseTool.performed += instance.OnUseTool;
                @UseTool.canceled += instance.OnUseTool;
            }
        }
    }
    public Player_FightingActions @Player_Fighting => new Player_FightingActions(this);

    // Player_UI
    private readonly InputActionMap m_Player_UI;
    private IPlayer_UIActions m_Player_UIActionsCallbackInterface;
    private readonly InputAction m_Player_UI_ClosePauseMenu;
    private readonly InputAction m_Player_UI_Navigate;
    private readonly InputAction m_Player_UI_Submit;
    private readonly InputAction m_Player_UI_Cancel;
    private readonly InputAction m_Player_UI_Point;
    private readonly InputAction m_Player_UI_LeftClick;
    public struct Player_UIActions
    {
        private @PlayerMovementActions m_Wrapper;
        public Player_UIActions(@PlayerMovementActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @ClosePauseMenu => m_Wrapper.m_Player_UI_ClosePauseMenu;
        public InputAction @Navigate => m_Wrapper.m_Player_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_Player_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_Player_UI_Cancel;
        public InputAction @Point => m_Wrapper.m_Player_UI_Point;
        public InputAction @LeftClick => m_Wrapper.m_Player_UI_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_Player_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_UIActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_UIActions instance)
        {
            if (m_Wrapper.m_Player_UIActionsCallbackInterface != null)
            {
                @ClosePauseMenu.started -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnClosePauseMenu;
                @ClosePauseMenu.performed -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnClosePauseMenu;
                @ClosePauseMenu.canceled -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnClosePauseMenu;
                @Navigate.started -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnPoint;
                @LeftClick.started -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_Player_UIActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_Player_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ClosePauseMenu.started += instance.OnClosePauseMenu;
                @ClosePauseMenu.performed += instance.OnClosePauseMenu;
                @ClosePauseMenu.canceled += instance.OnClosePauseMenu;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public Player_UIActions @Player_UI => new Player_UIActions(this);
    public interface IPlayer_FightingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnUseTool(InputAction.CallbackContext context);
    }
    public interface IPlayer_UIActions
    {
        void OnClosePauseMenu(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
    }
}
