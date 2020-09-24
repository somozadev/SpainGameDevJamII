using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    private InputAction moveAction;
    public Vector2 moveInput;
    public Vector3 moveDirection;

    private InputAction rotateAction;
    public Vector2 rotateInput;
    public Vector3 rotateDirection;

    public float speed;
    private PlayerInput playerInput;
    Rigidbody rb;




   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = transform.parent.GetComponent<PlayerInput>();

        moveAction = playerInput.actions["Movement"];
        moveAction.canceled += ctx => moveInput = Vector2.zero;

        rotateAction = playerInput.actions["Rotate"];
        rotateAction.canceled += ctx => rotateInput = Vector2.zero;
    }

    
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        moveDirection = new Vector3(moveInput.x, 0f, moveInput.y);

        rotateInput = rotateAction.ReadValue<Vector2>();
        rotateDirection = new Vector3(-rotateInput.x, 0f, -rotateInput.y);
        
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);

        if(rotateDirection != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(rotateDirection);
    }


    /*
    void OnEnable()
    {
        controls.Player.Enable();
    }
    void OnDisable()
    {
        controls.Player.Disable();
    }
    */



}
