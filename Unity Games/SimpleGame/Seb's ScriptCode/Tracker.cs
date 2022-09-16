using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    public float tempscore = 0;
    public float score = 0;
    
    void OnCollisionEnter()
    {
        tempscore++;
        if (tempscore == 8)
        {
            tempscore = 0;
            score++;
        }
    }
}
