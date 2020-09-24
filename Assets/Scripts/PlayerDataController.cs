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
    public DuelCase duelCase;
    private string actionMapUI = "Player_UI";
    private string actionMapFight = "Player_Fighting";
    public int id;
    public List<Sprite> players;

    public ScenesController scenesController;
    public GameObject fightScene;
    public GameObject controllerConnectionScene;



    void Update()
    {
        //SetControlScheme();
    }

    void Awake()
    {
       
        DontDestroyOnLoad(this);
        scenesController = GameObject.FindObjectOfType<ScenesController>(); 
    }

    void Start()
    {
        //if(SceneManager.GetActiveScene().name == "ControllerConnectionScreen")
        if(scenesController.futureCase == DuelCase.Connection)
            SetId();
        
    }



    public void SetDuelCase(DuelCase _duelCase)
    {
        duelCase = _duelCase;
    }
    /*
    public void SetControlScheme()
    {
        duelCase = scenesController.futureCase;
        switch (duelCase)
        {
            case DuelCase.Fighting:
                EnableFightingControls();
                fightScene.SetActive(true);
                controllerConnectionScene.SetActive(false);
                break;
            case DuelCase.Ui:
                EnableUiControls();
                fightScene.SetActive(false);
                controllerConnectionScene.SetActive(true);
                break;
        }
    }*/
    /*
    void EnableUiControls()
    {
        playerInput.SwitchCurrentActionMap(actionMapUI);
    }
    void EnableFightingControls()
    {
        playerInput.SwitchCurrentActionMap(actionMapFight);
    } */
    public PlayerInput GetPlayerInput()
    {
        return playerInput;
    }

    //called in controllerConnection scene 
    void SetId()
    {

        //AQUI GUARDAR EL DEVICEID QUE APRETE EL BOTON( INPUTSYSTEM.DEVICES[0,1,2,3,4...] Y ASOCIARLO CON EL ID DEL PLAYER de esta forma  if(InputSystem.devices[2].device.IsPressed())


        transform.position = Vector3.zero;
        Transform controllerConnectionScreenObject = transform.GetChild(0);

        if (GameObject.FindObjectsOfType<PlayerDataController>().Length == 1)
            id = 0;
        else if (GameObject.FindObjectsOfType<PlayerDataController>().Length == 2)
            id = 1;

        switch (id)
        {
            case 1:
                controllerConnectionScreenObject.position = new Vector3(-5, 0.34f, 0);
                controllerConnectionScreenObject.GetComponentInChildren<Canvas>().transform.GetChild(0).GetComponent<RectTransform>().localPosition = new Vector3(-480, -240, 0);
                controllerConnectionScreenObject.GetChild(1).GetComponent<SpriteRenderer>().sprite = players[0];
                controllerConnectionScreenObject.GetChild(0).transform.localPosition = new Vector3(-0.37f, 2.04f, 0);
                break;
            case 2:
                controllerConnectionScreenObject.position = new Vector3(5, 0.34f, 0);
                controllerConnectionScreenObject.GetComponentInChildren<Canvas>().transform.GetChild(0).GetComponent<RectTransform>().localPosition = new Vector3(480, -240, 0);
                controllerConnectionScreenObject.GetChild(1).GetComponent<SpriteRenderer>().sprite = players[1];
                controllerConnectionScreenObject.GetChild(0).transform.localPosition= new Vector3(-0.37f,2.04f,0);
                break;
        }
        foreach (TMP_Text text in controllerConnectionScreenObject.GetComponentsInChildren<TMP_Text>())
            text.text = "P " + (id+1).ToString();

    }


    /*
    public Vector3 moveDir;
    private void OnMovement(InputValue value)
    {
        Vector2 inputMovement = value.Get<Vector2>();
         moveDir = new Vector3(inputMovement.x, 0, inputMovement.y);
    }

    public Vector3 rotDir;
    private void OnRotate(InputValue value)
    {
        Vector2 inputRotate = value.Get<Vector2>();
        Debug.Log("Player " +id + " rotated!");
        rotDir = new Vector3(-inputRotate.x, 0, -inputRotate.y);
    }
    private void FixedUpdate()
    {
        if(duelCase == DuelCase.Fighting)
            MovePlayer();
    }
    void MovePlayer()
    {
        //Debug.LogWarning("PLAYER MOVING");
        GetComponentInChildren<Rigidbody>().MovePosition(GetComponentInChildren<Rigidbody>().transform.position + moveDir * 10 * Time.fixedDeltaTime);

        if (rotDir != Vector3.zero)
            GetComponentInChildren<Rigidbody>().transform.rotation = Quaternion.LookRotation(rotDir);
    }*/







    public int GetPlayerIndex() { return id; }









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
}
