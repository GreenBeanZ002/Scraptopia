using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    //Counts the time & Updates the display on screen
    public TMP_Text txt;
    public float time = 0;

    private void FixedUpdate()
    {
        time += Time.deltaTime;
        double tme = System.Math.Round(time, 2);
        txt.text = tme.ToString();
        
    }
}
