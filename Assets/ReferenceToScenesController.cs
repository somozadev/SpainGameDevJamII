using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceToScenesController : MonoBehaviour
{
    public ScenesController scenesController;

    void Start()
    {
        scenesController = GameObject.FindObjectOfType<ScenesController>();
    }

    public void LoadScene(int index)
    {
        scenesController.LoadScene(index); //this shall depend on the duelCase state
    }
}
