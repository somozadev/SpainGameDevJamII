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
    public int player1Pts, player2Pts;
    bool canAddpts = true;
    public GameObject player1, player2;
    public SOScores sOScores;

    float timeleft =3f;
    bool startCountDown = false;


    void Awake()
    {
        player1Pts = sOScores.p1Score;
        player2Pts = sOScores.p2Score;
        p1Points[0].text = sOScores.p1Score.ToString();
        p1Points[1].text = sOScores.p1Score.ToString();
        p2Points[0].text = sOScores.p2Score.ToString();
        p2Points[1].text = sOScores.p2Score.ToString();

        scenesController = FindObjectOfType<ScenesController>();
        timer = 300;

    }
    private void Start()
    {
        p1Points[0].text = sOScores.p1Score.ToString();
        p1Points[1].text = sOScores.p1Score.ToString();
        p2Points[0].text = sOScores.p2Score.ToString();
        p2Points[1].text = sOScores.p2Score.ToString();

    }
    public void GetWinningId()
    {
        if (looserId == 0)
            winnerId = 1;
        if (looserId == 1)
            winnerId = 0;
    }
    void Update()
    {
        if(startCountDown)
        {
            timeleft -= Time.deltaTime;
        }
        
        if (timer < 0 || winnerId != -1)
        {
            startCountDown = true;
            //add points, reload scene
            ChangePoints(winnerId); //reference winner player
            if(Convert.ToInt32(p1Points[0].text) >= maxRounds || Convert.ToInt32(p2Points[0].text) >= maxRounds)
            {
                
                if (timeleft <= 0)
                {
                    scenesController.LoadScene(0);
                }

                sOScores.p1Score = 0; sOScores.p2Score=0 ; winnerId = -1; looserId = -1;

            }
            else
            {
                if (timeleft <= 0)
                {
                    scenesController.LoadScene(2);
                }
                
                
                winnerId = -1; looserId = -1;
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
                sOScores.p1Score += 1;
                p1Points[0].text = sOScores.p1Score.ToString();
                p1Points[1].text = sOScores.p1Score.ToString();
                canAddpts = false;
            }
        }
        if (id == 1)
        {
                if (canAddpts)
                {
                sOScores.p2Score += 1;
                    p2Points[0].text = sOScores.p2Score.ToString();
                    p2Points[1].text = sOScores.p2Score.ToString();
                    canAddpts = false;
                }
        }
    }

}
