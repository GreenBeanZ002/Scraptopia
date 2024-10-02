using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
	public Camera cam;
	public int hits = 0;
    //Turns boxes red when a collision occurs with an object which has the "Player" tag 
    private void OnCollisionEnter(Collision collision)
	{

		if (collision.gameObject.CompareTag("Player"))
		{
			GetComponent<MeshRenderer>().material.color = Color.red;
			gameObject.tag = "Hit";

			GameObject[] hitObjs = GameObject.FindGameObjectsWithTag("Hit");
			//
			cam.GetComponent<hitstore>().clrHits();
			foreach (GameObject Obj in hitObjs)
            {
				cam.GetComponent<hitstore>().increaseHits();
			}
			//Possibly remove this bit with hitObjs.Count?

			
			
			
			
		}


	}
}

