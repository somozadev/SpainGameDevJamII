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

    private bool isMoving;
    
    void Start()
    {
        isMoving = false; 
        controlManager = FindObjectOfType<ControlManager>();
        rb = GetComponentInChildren<Rigidbody>();
    }

    void Movement()
    {
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.LeftKey)))
        {
            moveDirection = Vector3.left;
            isMoving = true;
        }
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.RightKey)))
        {
            moveDirection = Vector3.right;
            isMoving = true;
        }
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.UpKey)))
        {
            moveDirection = new Vector3(0, 0, 1);
            isMoving = true;
        }
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.DownKey)))
        {
            moveDirection = new Vector3(0, 0, -1);
            isMoving = true;
        }

    }
    void Attack()
    {
        if (Input.GetKey(controlManager.GetKey(playerID, ControlKeys.Action)))
            Debug.Log("Player " + playerID + " is attacking");
    }
    void Update()
    {
        Movement();
        Attack();
        
        if (moveDirection.x > 0 && playerID == 0)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }
        else if(moveDirection.x > 0 && playerID == 1)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
        if(moveDirection.x < 0 && playerID == 0)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
        else if(moveDirection.x < 0 && playerID == 1)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }

        
    }
    
    void FixedUpdate()
    {
        if (isMoving)
        rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
        else
            rb.MovePosition(rb.position + Vector3.zero);

    }
    



}
