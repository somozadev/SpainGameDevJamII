using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public float timer;
    public TMP_Text textTimer;
    public ScenesController scenesController;
    public List<TMP_Text> p1Points;
    public List<TMP_Text> p2Points;
    public int maxRounds;
    public int looserId = -1;
    public int winnerId = -1;
    public int player1Pts=0, player2Pts=0;
    bool canAddpts = true;

    void Awake()
    {
        scenesController = FindObjectOfType<ScenesController>();
        timer = 300;
        if(FindObjectsOfType<GameManager>().Length > 1)
        {
            foreach (GameManager gm in FindObjectsOfType<GameManager>())
            {
                if(gm!=this)
                    Destroy(gm.gameObject);
            }
        }
        DontDestroyOnLoad(this);
        FindTextsRefs();
    }
    void FindTextsRefs() { }

    public void GetWinningId()
    {
        if (looserId == 0)
            winnerId = 1;
        if (looserId == 1)
            winnerId = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (timer < 0 || winnerId != -1)
        {
            //add points, reload scene
            ChangePoints(winnerId); //reference winner player
            if(Convert.ToInt32(p1Points[0].text) >= maxRounds || Convert.ToInt32(p2Points[0].text) >= maxRounds)
            {
                scenesController.LoadScene(2);
                winnerId = -1; looserId = -1;

            }
            else
            {
                scenesController.LoadScene(0); //o una escena nueva con el sprite del ganador!
                player1Pts = 0; player2Pts = 0; winnerId = -1; looserId = -1;
            }
        }
        else
            timer -= Time.deltaTime;


        textTimer.text = (timer).ToString("0");
        
        
    }

    void ChangePoints(int id)
    {
        if (id == 0)
        {
            if (canAddpts)
            {
                player1Pts += 1;
                p1Points[0].text = player2Pts.ToString();
                p1Points[1].text = player2Pts.ToString();
                canAddpts = false;
            }
        }
        if (id == 1)
        {
                if (canAddpts)
                {
                    player2Pts += 1;
                    p2Points[0].text = player2Pts.ToString();
                    p2Points[1].text = player2Pts.ToString();
                    canAddpts = false;
                }
        }
    }

}
