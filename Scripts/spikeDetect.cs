using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeDetect : MonoBehaviour
{
    public float cooldownTimer = 1f;
    bool detectedPlayer;
    bool movedOnce = false;

    //When Player enters the Collider, updates detectedPlayer too true
    void OnTriggerEnter(Collider collisin)
    {
        if (collisin.CompareTag("Player"))
        {
            Debug.Log("Player Detected");
            detectedPlayer = true;
        }
        
    }
    private void Update()
    {
        if(detectedPlayer == true)
        {
            if (cooldownTimer <= 0)
            {
                Debug.Log("Spikes Raised");
                cooldownTimer = 3;
                detectedPlayer = false;
                if(movedOnce == false)
                {
                    transform.Translate(0, 1, 0);
                }
                movedOnce = true;
            }
            else
            {
                cooldownTimer -= Time.deltaTime;
            }
                    
        }
        
    }

}
