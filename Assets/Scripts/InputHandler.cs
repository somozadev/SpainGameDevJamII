using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class InputHandler : MonoBehaviour
{

    private PlayerDataController player;
    private PlayerInput playerInput;
    private InputHolder holder;



    private void Start()
    {
        playerInput = this.GetComponent<PlayerInput>();
        var index = playerInput.playerIndex;



        var players = FindObjectsOfType<PlayerDataController>();
        player = players.FirstOrDefault(m => m.GetPlayerIndex() == index);
        Debug.Log(player.name + ": " + player.GetPlayerIndex());


        holder = player.GetComponentInChildren<InputHolder>();
    }

    public void OnMovement(CallbackContext context)
    {
        if (player != null)
            holder.SetMoveInputVector(context.ReadValue<Vector2>());
    }
    public void OnRotate(CallbackContext context)
    {
        if (player != null)
            holder.SetLookInputVector(context.ReadValue<Vector2>());
    }










}
