using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InstantiateIngamePlayers : MonoBehaviour
{
    private PlayerInputManager inputManager;
    void Start()
    {
        inputManager = GameObject.FindObjectOfType<PlayerInputManager>();

        foreach(InputDevice dev in InputSystem.devices)
        {

            Debug.Log(dev.deviceId + "//" + dev.name);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(InputSystem.devices[2].device.IsPressed())
        { Debug.LogWarning("PRESSED BTN="); }
    }
}
