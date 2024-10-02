using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitstore : MonoBehaviour
{
    public float hits = 0;
    // Stores  and updates the "hits" variable allowing it to be accessible across the game. 
    void Start()
    {
        
    }
    public void increaseHits()
    {
        hits++;
        updateScore();
    }
    public void clrHits()
    {
        hits = 0;
    }
    void updateScore()
    {
        Debug.Log($"You've bumped into this many things: {hits}");
    }
}
