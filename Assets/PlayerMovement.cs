using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    PlayerMovementActions controls;
    public Vector2 moveInput, rotateInput;
    public Vector3 rotateDirection, moveDirection;
    public float speed;
    public float rotSpeed;
    Rigidbody rb;
    void Awake()
    {
        controls = new PlayerMovementActions();

        controls.Player.Movement.performed += context => moveInput = context.ReadValue<Vector2>();
        controls.Player.Movement.canceled += context => moveInput = Vector2.zero;

        controls.Player.Rotate.performed += context => rotateInput = context.ReadValue<Vector2>();
        controls.Player.Rotate.canceled += context => rotateInput = Vector2.zero;

    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
        rotateDirection = new Vector3(-rotateInput.x, 0f, -rotateInput.y);
        moveDirection = new Vector3(moveInput.x, 0f, moveInput.y);

    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);

        if(rotateDirection != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(rotateDirection);
    }



    void OnEnable()
    {
        controls.Player.Enable();
    }
    void OnDisable()
    {
        controls.Player.Disable();
    }




}
