using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public delegate void PickUpToolDelegate(GameObject tool, GameObject _hand, Player player, string _toolName);
    public event PickUpToolDelegate pickUpToolEvent;
    public GameObject hand;

    public delegate void DropToolDelegate(GameObject tool,Player player, string _toolName);
    public event DropToolDelegate DropToolEvent;

    public delegate void AttackDelegate();
    public event AttackDelegate AttackEvent;

    public delegate void ShowIconPromtsDelegate(bool showIcon);
    public event ShowIconPromtsDelegate ShowIconPromptEvent;


    private Rigidbody rb;
    private PlayerInput playerInput;
    private InputAction interactAction;
    private InputAction dropAction;
    private InputAction triggerAction;

    private string toolName;
    private bool isGameStarted;
    private bool isRightTriggerPressed;
    private bool hasEquipment;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        interactAction = playerInput.actions["Interact"];
        dropAction = playerInput.actions["Drop"];
        triggerAction= playerInput.actions["UseTool"];


        triggerAction.started += ctx => isRightTriggerPressed = true;
        triggerAction.canceled += ctx => isRightTriggerPressed = false;

    }

    void Update()
    {
        if(hasEquipment)
        {

        }
        if(dropAction.triggered && hasEquipment)
        {
           // DropTool(gameObject.transform.GetChild(0).GetChild(0).GetChild(0).gameObject);
            hasEquipment = false;
        }

        if(isRightTriggerPressed && toolName == "Proyectile")
        {
          //  ThrowProyectile();
        }


    }





    void PickUpTool(GameObject tool)
    {
        if(pickUpToolEvent != null)
        {
           // pickUpToolEvent(tool);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

    }
}
