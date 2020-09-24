using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



//Se encarga de asociar el mando (mediante su id) con el id del jugador instanciado

public class PlayerConnectionsManager : MonoBehaviour
{
    public PlayerInputManager inputManager;
    public int deviceId1,playerId1;
    public int deviceId2, playerId2;
    public bool waitForConnections;

    private List<InputDevice> devicesConnected;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        waitForConnections = true;
        devicesConnected = new List<InputDevice>();
        inputManager = GameObject.FindObjectOfType<PlayerInputManager>();
    }

    public void FindNewInputManagerReference()
    {
        inputManager = GameObject.FindObjectOfType<PlayerInputManager>();
    }
    private void Start()
    {
        
    }

    public void ResetDevices()
    {
        foreach(InputDevice device in devicesConnected)
        {
           // device.pare
        }
    }

    private void Update()
    {
        if(waitForConnections)
        {

            foreach (InputDevice dev in InputSystem.devices)
            {
                if (dev.IsPressed() && !devicesConnected.Contains(dev) && (dev.deviceId != 0 || dev.deviceId != 1))
                    devicesConnected.Add(dev);
                if (deviceId1 == 0 && playerId1 == 0 && dev.IsPressed() && GameObject.FindObjectsOfType<PlayerDataController>().Length == 1)
                {
                    deviceId1 = dev.deviceId;
                    playerId1 = 1;
                    //player1 always is the men
                }
                if (deviceId2 == 0 && playerId2 == 0 && dev.IsPressed() && GameObject.FindObjectsOfType<PlayerDataController>().Length >= 2)
                {
                    deviceId2 = dev.deviceId;
                    playerId2 = 2;
                    //player2 always is the woman
                    waitForConnections = false;
                }
            }

        }
        if(!waitForConnections)
        {
            inputManager.DisableJoining();
            foreach (InputDevice d in devicesConnected)
            {
                if (d.name == "Mouse" || d.name == "Keyboard")
                    devicesConnected.Remove(d);
            }
        }
    }

}
