using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MultiplayerManager : MonoBehaviour
{
    // when start -> press l1 + r1 to connect controller

    public PlayerInputManager playerInputManager;
    public List<PlayerInput> players;


    void Start()
    {
        playerInputManager = GetComponent<PlayerInputManager>();
    }
    void Update()
    {

        if (playerInputManager.playerCount >= 2)
            playerInputManager.DisableJoining();
        else
            playerInputManager.EnableJoining();

    }
}
