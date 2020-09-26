using System;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class ControlManager : MonoBehaviour
{
    [Serializable]
    private class PlayerControls
    {
        public List<keyCode> keyCodes;
        public KeyCode GetKeyCode(ControlKeys controlKey)
        {
            foreach(keyCode kc in keyCodes)
            {
                if (kc.controlKey == controlKey)
                    return kc.key;
            }
            return KeyCode.None;
        }
    }
    [Serializable]
    private class keyCode
    {
        public ControlKeys controlKey;
        public KeyCode key;
    }

    [SerializeField] List<PlayerControls> playerControls;

    
    public KeyCode GetKey(int playerID, ControlKeys controlKeys)
    {
        return playerControls[playerID].GetKeyCode(controlKeys);
    }


}
