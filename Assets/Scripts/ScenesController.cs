using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    public Scene actualScene;
    public PlayerDataController.DuelCase futureCase;
    public List<PlayerDataController.DuelCase> casesList;

    void Start()
    {
        GetAllCases();
        DontDestroyOnLoad(this.gameObject);
        SetCurrentScene();
        casesList = PlayerDataController.GetEnumList<PlayerDataController.DuelCase>();
    }

    void GetAllCases()
    {
        // casesList = new list<DuelCase>();
        // foreach(DuelCase case in Enum.GetNames(typeof(DuelCase)))
        // {
        //     casesList.add(case);
        // }
    }

    public void RandomNewDuelCase()    
    {
            futureCase = casesList[Random.Range(1, casesList.Count)];
    
    }


    




    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
        GetCurrentScene();
        if (actualScene.name == "ControllerConnectionScene")
            futureCase = casesList[0];
        if (actualScene.name != "StartScene" && actualScene.name != "ControllerConnectionScene")
            futureCase = casesList[1];//RandomNewDuelCase();

        /*
        switch(index)
        {
            case 1:
                playerDataController.SetDuelCase(PlayerDataController.DuelCase.Connection);
            break;
            case 2:
                playerDataController.SetDuelCase(PlayerDataController.DuelCase.Fighting);
            break;
        } 
        playerDataController.SetControlScheme(); */
    }

    public void SetCurrentScene()
    {
        actualScene = SceneManager.GetActiveScene();
    }
    public Scene GetCurrentScene()
    {
        SetCurrentScene();
        return actualScene;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    

}
