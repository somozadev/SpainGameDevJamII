using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public Vector3 moveDirection;
    public Vector3 rotateDirection;

    public int playerId,deviceConnectedId;
    public bool AmIPlayerOne, AmIPlayerTwo;
    public float speed;
    private Rigidbody rb;
    public PlayerConnectionsManager playerConnectionsManager;
    public InputHolder inputHolder;


    void Awake()
    {
        if(AmIPlayerOne){ AmIPlayerTwo = false;}
        else {AmIPlayerTwo = true;}
        inputHolder = GetComponentInChildren<InputHolder>();
    }
   
    void Start()
    {
        playerConnectionsManager = GameObject.FindObjectOfType<PlayerConnectionsManager>();
        if(AmIPlayerOne)
        {
            playerId = playerConnectionsManager.playerId1-1;
            deviceConnectedId = playerConnectionsManager.deviceId1;
        }
        if(AmIPlayerTwo)
        {
            playerId = playerConnectionsManager.playerId2-1;
            deviceConnectedId = playerConnectionsManager.deviceId2;
        }
        rb = GetComponentInChildren<Rigidbody>();
    }

    
    void Update()
    {
        moveDirection = new Vector3(inputHolder.movementInput.x, 0f, inputHolder.movementInput.y);
        if(moveDirection.x > 0 && AmIPlayerOne)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }
        else if(moveDirection.x < 0 && AmIPlayerOne)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
        if(moveDirection.x > 0 && AmIPlayerTwo)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
        else if(moveDirection.x < 0 && AmIPlayerTwo)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }
        rotateDirection = new Vector3(-inputHolder.lookInput.x, 0f, -inputHolder.lookInput.y);
        
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);

        //if(rotateDirection != Vector3.zero)
            //rb.transform.rotation = Quaternion.LookRotation(rotateDirection);
    }

    public int GetPlayerIndex() { return playerId; }
    public int GetDeviceConnectedId() { return deviceConnectedId; }



}
