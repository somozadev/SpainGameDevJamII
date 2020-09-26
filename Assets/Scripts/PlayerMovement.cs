using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class PlayerMovement : MonoBehaviour
{


    [SerializeField] int playerID;

    ControlManager controlManager;

    public Vector3 moveDirection;
    public Vector3 rotateDirection;
    
    public float speed;
    private Rigidbody rb;
    private CharacterController controller;
    bool isGrounded;
    
    void Start()
    {
        
        controller = GetComponentInChildren<CharacterController>();
        controlManager = FindObjectOfType<ControlManager>();
        rb = GetComponentInChildren<Rigidbody>();
    }
    void MovePlayer()
    {
        controller.Move(moveDirection * Time.deltaTime * speed);
        //rb.MovePosition(rb.transform.position + moveDirection * speed * Time.deltaTime);
        //transform.Translate(moveDirection * speed * Time.deltaTime);
    }
    void Movement()
    {
        isGrounded = controller.isGrounded;

        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.LeftKey)))
        {
            moveDirection = Vector3.left;
            MovePlayer();
        }
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.RightKey)))
        {
            moveDirection = Vector3.right;
            MovePlayer();
        }
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.UpKey)))
        {
            moveDirection = new Vector3(0, 0, 1);
            MovePlayer();
        }
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.DownKey)))
        {
            moveDirection = new Vector3(0, 0, -1);
            MovePlayer();
        }

    }
    void Attack()
    {
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.Attack)))
            Debug.Log("Player " + playerID + " is attacking");
    }
    void CheckVisuals()
    {
        if (moveDirection.x > 0 && playerID == 0)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }
        else if (moveDirection.x > 0 && playerID == 1)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
        if (moveDirection.x < 0 && playerID == 0)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
        else if (moveDirection.x < 0 && playerID == 1)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }

    }
    void Update()
    {
        Movement();
        Attack();
        CheckVisuals();
       
    }
    
    void FixedUpdate()
    {
       

    }
    



}
