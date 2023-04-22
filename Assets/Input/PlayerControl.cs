//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/PlayerControl.inputactions
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

public partial class @PlayerControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c7ec98f0-b7d4-47fe-a1e6-87c40af73e11"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""c5c61537-5941-4d83-bc6e-16e69f7e5f6c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""56f29da2-6b86-43b4-b9b7-eef1de6cd121"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""9c9fec2d-ef1a-4581-9f5c-68512854083f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""7598eab3-78f1-40d0-ba2f-cd5f9e978ec1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1fb42583-33ff-4ef2-a50d-ecf47148458f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""516ebc5f-a6b1-40f6-87f9-41175bef9e57"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6293af53-f5d1-4887-aa05-18eb6cd71287"",
                    ""path"": ""1DAxis(minValue=-3,maxValue=3)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8630f0fd-80e9-491c-9b0c-6b3c8bdb091f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""75b9fcb3-4aa3-40ad-b21a-b1e020084780"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""540697d6-e8b1-4378-8664-7f19ba19f22f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""970df273-0347-4b8f-892a-62cd894d56d2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""37ee6af2-bde6-4ea1-a057-72402a955aa0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f47af06f-7865-4e25-bf87-fbb280d27c77"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""807e8a3a-5bfc-4efe-bce3-67ea1cc56e78"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f0d3255b-66db-4453-a9a1-ed70a199ab87"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Roate"",
                    ""type"": ""Value"",
                    ""id"": ""9d47f5d3-924c-4651-a42f-529e083588c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""UpDown"",
                    ""type"": ""Value"",
                    ""id"": ""888c3c48-00cd-4d86-a8da-45c67f0819cc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""be22bb36-d802-46b2-9191-035f5cd2678c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""dfba74e4-46da-482f-9481-801f92e1e09d"",
                    ""path"": ""1DAxis(minValue=-30,maxValue=30)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""aa7c5e0f-9a44-4c1c-8e07-49ad67168c4a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e748cf92-277c-4ea8-9e58-f1478cd5f202"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c58d6317-8193-47f6-974e-23d5aaf28f34"",
                    ""path"": ""1DAxis(minValue=-5,maxValue=5)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e2a0d169-9512-47be-b12c-84f648c8efc8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4efcbe17-d2fb-4859-981b-a54deb0cdcce"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""4088173c-6f28-4c3a-9d98-4711c134b4aa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3db5b991-74c2-4a7a-bf2c-499f85f6abf4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0af3030c-d3ca-48d8-b853-f05bbec0d465"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""993c0a96-304e-4d0d-a1db-656b1cffdf3a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ForkLift"",
            ""id"": ""3fd59047-2986-4cd7-a4bb-85119714e591"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b99d3fc9-3382-4e51-9592-00618ee6e01b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Roate"",
                    ""type"": ""Value"",
                    ""id"": ""fccecd9b-5767-4b13-98a1-37b123492c75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LiftControlUp"",
                    ""type"": ""Button"",
                    ""id"": ""a4e34b2b-9247-414c-a22a-7432ccd64afb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LiftControlDown"",
                    ""type"": ""Button"",
                    ""id"": ""06770aae-4f7a-4a7a-ace0-213c8487b997"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""ae621877-1d79-4ce7-bb05-5e89012df2a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8106eaed-8f7d-44da-a7b0-09aa11ebc999"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1a82484e-164e-41fc-80eb-38305ae4ea35"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0566766b-e971-420c-8dcb-d8cc7cea7049"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a31d4e63-12f8-423a-af6e-0b99655852db"",
                    ""path"": ""1DAxis(minValue=-5,maxValue=5)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2d5ad995-c2ab-40d4-a3bd-b8bbf634ad17"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9bd9aad8-3d14-4478-b52d-b3dc5540da94"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8eaa458e-adaf-4d90-abc2-6c6a9dcd360c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftControlUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94165f2a-8bc5-4073-84b2-58a5aac1819c"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftControlDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b109f36-4b43-46ac-b730-d3a9287e15be"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Crate"",
            ""id"": ""ef2f1c8a-ca3f-4d7b-bc93-cb81409bfa5e"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""87b7eae7-2979-4337-958e-d3046398ac95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""df5fc3b5-4b9b-40fc-b1d6-c21c6e5a9941"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
        m_Player_Interaction = m_Player.FindAction("Interaction", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_Esc = m_Player.FindAction("Esc", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_Movement = m_Drone.FindAction("Movement", throwIfNotFound: true);
        m_Drone_Roate = m_Drone.FindAction("Roate", throwIfNotFound: true);
        m_Drone_UpDown = m_Drone.FindAction("UpDown", throwIfNotFound: true);
        m_Drone_Esc = m_Drone.FindAction("Esc", throwIfNotFound: true);
        // ForkLift
        m_ForkLift = asset.FindActionMap("ForkLift", throwIfNotFound: true);
        m_ForkLift_Movement = m_ForkLift.FindAction("Movement", throwIfNotFound: true);
        m_ForkLift_Roate = m_ForkLift.FindAction("Roate", throwIfNotFound: true);
        m_ForkLift_LiftControlUp = m_ForkLift.FindAction("LiftControlUp", throwIfNotFound: true);
        m_ForkLift_LiftControlDown = m_ForkLift.FindAction("LiftControlDown", throwIfNotFound: true);
        m_ForkLift_Esc = m_ForkLift.FindAction("Esc", throwIfNotFound: true);
        // Crate
        m_Crate = asset.FindActionMap("Crate", throwIfNotFound: true);
        m_Crate_Tap = m_Crate.FindAction("Tap", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Walk;
    private readonly InputAction m_Player_Interaction;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_Esc;
    public struct PlayerActions
    {
        private @PlayerControl m_Wrapper;
        public PlayerActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Player_Walk;
        public InputAction @Interaction => m_Wrapper.m_Player_Interaction;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @Esc => m_Wrapper.m_Player_Esc;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                @Interaction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteraction;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Esc.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEsc;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    private readonly InputAction m_Drone_Movement;
    private readonly InputAction m_Drone_Roate;
    private readonly InputAction m_Drone_UpDown;
    private readonly InputAction m_Drone_Esc;
    public struct DroneActions
    {
        private @PlayerControl m_Wrapper;
        public DroneActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Drone_Movement;
        public InputAction @Roate => m_Wrapper.m_Drone_Roate;
        public InputAction @UpDown => m_Wrapper.m_Drone_UpDown;
        public InputAction @Esc => m_Wrapper.m_Drone_Esc;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Roate.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRoate;
                @Roate.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRoate;
                @Roate.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRoate;
                @UpDown.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnUpDown;
                @Esc.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnEsc;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Roate.started += instance.OnRoate;
                @Roate.performed += instance.OnRoate;
                @Roate.canceled += instance.OnRoate;
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // ForkLift
    private readonly InputActionMap m_ForkLift;
    private IForkLiftActions m_ForkLiftActionsCallbackInterface;
    private readonly InputAction m_ForkLift_Movement;
    private readonly InputAction m_ForkLift_Roate;
    private readonly InputAction m_ForkLift_LiftControlUp;
    private readonly InputAction m_ForkLift_LiftControlDown;
    private readonly InputAction m_ForkLift_Esc;
    public struct ForkLiftActions
    {
        private @PlayerControl m_Wrapper;
        public ForkLiftActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ForkLift_Movement;
        public InputAction @Roate => m_Wrapper.m_ForkLift_Roate;
        public InputAction @LiftControlUp => m_Wrapper.m_ForkLift_LiftControlUp;
        public InputAction @LiftControlDown => m_Wrapper.m_ForkLift_LiftControlDown;
        public InputAction @Esc => m_Wrapper.m_ForkLift_Esc;
        public InputActionMap Get() { return m_Wrapper.m_ForkLift; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ForkLiftActions set) { return set.Get(); }
        public void SetCallbacks(IForkLiftActions instance)
        {
            if (m_Wrapper.m_ForkLiftActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMovement;
                @Roate.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnRoate;
                @Roate.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnRoate;
                @Roate.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnRoate;
                @LiftControlUp.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftControlUp;
                @LiftControlUp.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftControlUp;
                @LiftControlUp.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftControlUp;
                @LiftControlDown.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftControlDown;
                @LiftControlDown.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftControlDown;
                @LiftControlDown.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLiftControlDown;
                @Esc.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnEsc;
            }
            m_Wrapper.m_ForkLiftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Roate.started += instance.OnRoate;
                @Roate.performed += instance.OnRoate;
                @Roate.canceled += instance.OnRoate;
                @LiftControlUp.started += instance.OnLiftControlUp;
                @LiftControlUp.performed += instance.OnLiftControlUp;
                @LiftControlUp.canceled += instance.OnLiftControlUp;
                @LiftControlDown.started += instance.OnLiftControlDown;
                @LiftControlDown.performed += instance.OnLiftControlDown;
                @LiftControlDown.canceled += instance.OnLiftControlDown;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
            }
        }
    }
    public ForkLiftActions @ForkLift => new ForkLiftActions(this);

    // Crate
    private readonly InputActionMap m_Crate;
    private ICrateActions m_CrateActionsCallbackInterface;
    private readonly InputAction m_Crate_Tap;
    public struct CrateActions
    {
        private @PlayerControl m_Wrapper;
        public CrateActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_Crate_Tap;
        public InputActionMap Get() { return m_Wrapper.m_Crate; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CrateActions set) { return set.Get(); }
        public void SetCallbacks(ICrateActions instance)
        {
            if (m_Wrapper.m_CrateActionsCallbackInterface != null)
            {
                @Tap.started -= m_Wrapper.m_CrateActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_CrateActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_CrateActionsCallbackInterface.OnTap;
            }
            m_Wrapper.m_CrateActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
            }
        }
    }
    public CrateActions @Crate => new CrateActions(this);
    public interface IPlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRoate(InputAction.CallbackContext context);
        void OnUpDown(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
    }
    public interface IForkLiftActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRoate(InputAction.CallbackContext context);
        void OnLiftControlUp(InputAction.CallbackContext context);
        void OnLiftControlDown(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
    }
    public interface ICrateActions
    {
        void OnTap(InputAction.CallbackContext context);
    }
}
