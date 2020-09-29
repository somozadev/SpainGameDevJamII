using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScores : MonoBehaviour
{
    public SOScores scores;
    void Start()
    {
        scores.p1Score = 0;
        scores.p2Score = 0;
    }

    
}
