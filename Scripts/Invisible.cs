using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
	[SerializeField] float timeToWait = 5f; //Shows "timeToWait" in the Unity Editor

	MeshRenderer rendererRef;

	//Disables Mesh Renderer until timeToWait is complete.
	void Start()
	{
		rendererRef = GetComponent<MeshRenderer>();
		rendererRef.enabled = false;
	}

	void Update()
	{
		if (Time.time > timeToWait)
		{
			rendererRef.enabled = true;
		}
	}
}
