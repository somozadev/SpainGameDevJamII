using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class InputHandler : MonoBehaviour
{

    public PlayerMovement player;  //esto cambiarlo a script que tendra el player inminigamae
    public PlayerInput playerInput;
    public InputHolder holder;
    public PlayerConnectionsManager playerConnectionsManager;

    public int id;


    private void Start()
    {
        playerConnectionsManager = GameObject.FindObjectOfType<PlayerConnectionsManager>();
        playerInput = this.GetComponent<PlayerInput>();
        id = playerInput.playerIndex;
       
        var players = FindObjectsOfType<PlayerMovement>();
        player = players.FirstOrDefault(m => m.GetPlayerIndex() == id);

    

        holder = player.GetComponentInChildren<InputHolder>();
    }
    /*
    private void Update()
    {
        if(holder== null)
        {

            holder = player.GetComponentInChildren<InputHolder>();
        }
    }*/
    public void OnMovement(InputValue context)
    {
        if (player != null)
            holder.SetMoveInputVector(context.Get<Vector2>());
    }
    public void OnRotate(InputValue context)
    {
        if (player != null)
            holder.SetLookInputVector(context.Get<Vector2>());
    }










}
