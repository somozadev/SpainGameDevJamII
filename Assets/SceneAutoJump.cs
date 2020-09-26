using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAutoJump : MonoBehaviour
{
    public ScenesController scenesController;
    public float waitTime;
    public Animator anim;
    private void Start()
    {
        scenesController = GameObject.FindObjectOfType<ScenesController>();
        StartCoroutine("WaitToChangeScene");
        
    }

    public IEnumerator WaitToChangeScene()
    {
        yield return new WaitForSeconds(waitTime);
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(2.067f);
        scenesController.LoadScene(2);
    }
}
