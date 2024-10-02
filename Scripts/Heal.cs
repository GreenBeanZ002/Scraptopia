using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    float cooldownTimer = 3f;
    
    void Update()
    {
        //Waits 3 ticks then turns walls blue again
        if(gameObject.tag == "Hit")
        {
            if (cooldownTimer <= 0)
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;
            }
            else
            {
                cooldownTimer -= Time.deltaTime;
            }

        }
    }
}
