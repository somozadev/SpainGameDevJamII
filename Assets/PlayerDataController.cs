using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDataController : MonoBehaviour
{

    public PlayerInput playerInput;
    public DuelCase duelCase;
    private string actionMapUI = "Player_UI";
    private string actionMapFight = "Player_Fighting";

    void Update()
    {

    }

    




    public void SetDuelCase(DuelCase _duelCase)
    {
        duelCase = _duelCase;
    }
    void OnInteract()
    {
    
    }
    public void setControlScheme()
    {
        switch(duelCase)
        {
            case DuelCase.Fighting:
                EnableFightingControls();
                break;
            case DuelCase.Ui:
                EnableUiControls();
                break;
        }
    }
    void EnableUiControls()
    {
        playerInput.SwitchCurrentActionMap(actionMapUI);
    }
    void EnableFightingControls()
    {
        playerInput.SwitchCurrentActionMap(actionMapFight);
    }
    public PlayerInput GetPlayerInput()
    {
        return playerInput;
    } 

    public enum DuelCase
    {
        Fighting,
        Ui,
        Cards
    };
}
