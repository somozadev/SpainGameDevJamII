using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class PlayerDataController : MonoBehaviour
{
    //cambiarlo para que instancie los objetos de los players al cambiar de escena!!! aquellos que no tienen player input component

    public PlayerInput playerInput;
    public int id;
    public List<Sprite> players;

    
    public GameObject fightScene;
    public GameObject controllerConnectionScene;

    private PlayerConnectionsManager playerConnectionsManager;


    private void Awake()
    {
        playerConnectionsManager = GameObject.FindObjectOfType<PlayerConnectionsManager>();
        playerConnectionsManager.playerInputs.Add(this.GetComponent<PlayerInput>());
    }
    void Start()
    {
        SetId();
    }


 
   
    void SetId()
    {

        transform.position = Vector3.zero;
        Transform controllerConnectionScreenObject = transform.GetChild(0);

        if (GameObject.FindObjectsOfType<PlayerDataController>().Length == 1)
            id = 0;
        else if (GameObject.FindObjectsOfType<PlayerDataController>().Length == 2)
            id = 1;

        switch (id)
        {
            case 0:
                controllerConnectionScreenObject.position = new Vector3(-5, 0.34f, 0);
                controllerConnectionScreenObject.GetComponentInChildren<Canvas>().transform.GetChild(0).GetComponent<RectTransform>().localPosition = new Vector3(-480, -240, 0);
                controllerConnectionScreenObject.GetChild(1).GetComponent<SpriteRenderer>().sprite = players[0];
                controllerConnectionScreenObject.GetChild(0).transform.localPosition = new Vector3(-0.37f, 2.04f, 0);
                //look4decive1
                break;
            case 1:
                controllerConnectionScreenObject.position = new Vector3(5, 0.34f, 0);
                controllerConnectionScreenObject.GetComponentInChildren<Canvas>().transform.GetChild(0).GetComponent<RectTransform>().localPosition = new Vector3(480, -240, 0);
                controllerConnectionScreenObject.GetChild(1).GetComponent<SpriteRenderer>().sprite = players[1];
                controllerConnectionScreenObject.GetChild(0).transform.localPosition= new Vector3(-0.37f,2.04f,0);
                //look4device2
                break;
        }
        foreach (TMP_Text text in controllerConnectionScreenObject.GetComponentsInChildren<TMP_Text>())
            text.text = "P " + (id+1).ToString();

    }


    public PlayerInput GetPlayerInput() { return playerInput; }

    public int GetPlayerIndex() { return id; }


}


/*
 * 
 * 
 * 
 * 
    public DuelCase duelCase;
    private string actionMapUI = "Player_UI";
    private string actionMapFight = "Player_Fighting";
    public enum DuelCase
    {
        Connection,
        Fighting,
        Ui,
        Cards
    };
    public static List<T> GetEnumList<T>()
    {
        T[] array = (T[])Enum.GetValues(typeof(T));
        List<T> list = new List<T>(array);
        return list;
    }
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */