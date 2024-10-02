using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
	[SerializeField] float xAngle = 0;
	[SerializeField] float yAngle = 0;
	[SerializeField] float zAngle = 0;

	[SerializeField] int speed = 50;

	protected void Update(){
        transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
    }
}
