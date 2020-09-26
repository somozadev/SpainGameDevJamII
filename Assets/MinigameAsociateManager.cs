using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MinigameAsociateManager : MonoBehaviour
{
    public PlayerConnectionsManager playerConnectionsManager;
    public GameObject prefab;
    public int maxPlayers;

    private bool p1Instantiated, p2Instantiated;
    //private List<InputDevice> gamepads;

    private void Start()
    {
        p1Instantiated = false;
        p2Instantiated = false;
        playerConnectionsManager = GameObject.FindObjectOfType<PlayerConnectionsManager>();
        //gamepads = new List<InputDevice>();
        var inst = GetComponent<PlayerInputManager>().JoinPlayer(0, controlScheme: "LKeyboard", pairWithDevice: Keyboard.current);
        inst.defaultControlScheme.Equals("LKeyboard");
        var inst2 = GetComponent<PlayerInputManager>().JoinPlayer(1, controlScheme: "RKeyboard", pairWithDevice: Keyboard.current);
        inst2.defaultControlScheme.Equals("RKeyboard");
        
       


    }
    /*
    private void Update()
    {

        foreach(Gamepad g in Gamepad.all)
        { 
            Debug.LogWarning(g.name + g.deviceId + g.device);
        }

        Keyboard device = Keyboard.current;

        //foreach(Gamepad device in gamepads)
        //{
            
                //Debug.Log(device.name + ":" + device.deviceId + "////");
                //if (device.deviceId == playerConnectionsManager.deviceId1 && !p1Instantiated) //deviceId.Equals(playerConnectionsManager.deviceId1)
                //{
                    //if (device.IsPressed())
                    //{
                        Debug.Log("1>>>>>>>>>>" + device);
                        //GameObject inst = Instantiate(prefab); //! instanciar desde inputsytm???
                        var inst = PlayerInput.Instantiate(prefab,controlScheme:"LKeyboard", pairWithDevice: Keyboard.current);
                        //inst.GetComponent<InputHandler>().deviceIndex = playerConnectionsManager.deviceId1;
                        p1Instantiated = true;
                        gamepads.Remove(device);
                    //}
                //}
                //if (device.deviceId == playerConnectionsManager.deviceId2 && !p2Instantiated)
                //{
                    //if (device.IsPressed())
                    //{
                        Debug.Log("2>>>>>>>>>>" + device);
                        //GameObject inst = Instantiate(prefab);
                        //PlayerInput.FindFirstPairedToDevice(device);
                        var inst2 = PlayerInput.Instantiate(prefab, controlScheme: "RKeyboard", pairWithDevice: Keyboard.current);
                       

                        //inst.GetComponent<InputHandler>().deviceIndex = playerConnectionsManager.deviceId2;
                        p2Instantiated = true;
                        gamepads.Remove(device);
                    //}
                //}
            
            
        //}
    }
    */
}
