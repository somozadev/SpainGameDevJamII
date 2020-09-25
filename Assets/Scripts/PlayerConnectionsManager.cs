using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;



//Se encarga de asociar el mando (mediante su id) con el id del jugador instanciado

public class PlayerConnectionsManager : MonoBehaviour
{
    public PlayerInputManager inputManager;

    public int deviceId1,playerId1;
    public int deviceId2, playerId2;
    public string deviceName1,deviceName2;
    public bool waitForConnections;
    public List<PlayerInput> playerInputs;

    private void Awake()
    {

        if(playerInputs.Count == 0)
            playerInputs = new List<PlayerInput>();
        waitForConnections = true;
        inputManager = GameObject.FindObjectOfType<PlayerInputManager>();
        DontDestroyOnLoad(this);
    }

    public void FindNewInputManagerReference()
    {
        inputManager = GameObject.FindObjectOfType<PlayerInputManager>();
    }
    private void Start()
    {
        
    }

   

    private void Update()
    {
        if(waitForConnections)
        {

            foreach (InputDevice dev in InputSystem.devices)
            {
              
                if (GameObject.FindObjectsOfType<PlayerDataController>().Length == 1)
                {
                    deviceId1 = playerInputs[0].devices[0].deviceId;
                    playerId1 = 1;
                    deviceName1 = playerInputs[0].devices[0].name;
                    //player1 always is the men
                }
                if (GameObject.FindObjectsOfType<PlayerDataController>().Length >= 2)
                {
                    deviceId2 = playerInputs[1].devices[0].deviceId;
                    playerId2 = 2;
                    deviceName2 = playerInputs[1].devices[0].name;
                    //player2 always is the woman
                    waitForConnections = false;
                }
            }

        }
        if(!waitForConnections)
        {
            inputManager.DisableJoining();
        }
    }

}
