using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    public Scene actualScene;
    public PlayerDataController playerDataController;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        GetCurrentScene();
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
        GetCurrentScene();
        switch(index)
        {
            case 2:
                playerDataController.SetDuelCase(PlayerDataController.DuelCase.Fighting);
            break;
        } 
        playerDataController.setControlScheme();
    }

    public void GetCurrentScene()
    {
        actualScene = SceneManager.GetActiveScene();
    }

    public void QuitGame()
    {
        Application.Quit();
    }



}
