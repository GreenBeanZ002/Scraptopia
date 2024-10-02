using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
	[SerializeField] float timeToWait = 5f; //Shows "timeToWait" in the Unity Editor

	MeshRenderer rendererRef;
	Rigidbody rigid;

	void Start()
	{
		//Stops objects' falling 
		rendererRef = GetComponent<MeshRenderer>();
		rigid = GetComponent<Rigidbody>();

		rendererRef.enabled = false;
		rigid.useGravity = false;
	}

	void Update()
	{
		//Allows objects' falling after the time to wait is complete
		if (Time.time > timeToWait)
		{
			rendererRef.enabled = true;
			rigid.useGravity = true;
		}
	}
}
