using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MinigameAsociateManager : MonoBehaviour
{
    public PlayerConnectionsManager playerConnectionsManager;
    public GameObject prefab;
    //public int maxPlayers;
    private bool p1Instantiated, p2Instantiated;
    private List<InputDevice> gamepads;

    private void Start()
    {
        p1Instantiated = false;
        p2Instantiated = false;
        playerConnectionsManager = GameObject.FindObjectOfType<PlayerConnectionsManager>();
        gamepads = new List<InputDevice>();
        foreach (InputDevice device in InputSystem.devices)
        {
            if (device.name != "Keyboard" && device.name != "Mouse")
            {
                gamepads.Add(device);
            }

        }
    }

    private void Update()
    {
        foreach(InputDevice device in InputSystem.devices)
        {
            if(device.deviceId != 1 && device.deviceId != 2)
            {
                Debug.Log(device.name + ":" + device.deviceId + "////");
                if (device.deviceId.Equals(playerConnectionsManager.deviceId1) && !p1Instantiated)
                {
                    if (device.IsPressed())
                    {
                        //GameObject inst = Instantiate(prefab); //! instanciar desde inputsytm???
                        GameObject inst = PlayerInput.Instantiate(prefab).gameObject;
                        inst.GetComponent<InputHandler>().deviceIndex = playerConnectionsManager.deviceId1;
                        p1Instantiated = true;
                    }
                }
                if (device.deviceId.Equals(playerConnectionsManager.deviceId2) && !p2Instantiated && device.IsPressed())
                {
                    if (device.IsPressed())
                    {
                        GameObject inst = Instantiate(prefab);
                        PlayerInput.FindFirstPairedToDevice(device);
                        inst.GetComponent<InputHandler>().deviceIndex = playerConnectionsManager.deviceId2;
                        p2Instantiated = true;
                    }
                }
            }
            
        }
    }

}
