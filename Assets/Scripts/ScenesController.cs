using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    [HideInInspector]public Scene actualScene;
    private Animator anim;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        SetCurrentScene();
    }
    

    public void LoadScene(int index)
    {
        StartCoroutine(LoadNewScene(index));
        GetCurrentScene();
    }

    IEnumerator LoadNewScene(int index)
    {
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(index);
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
