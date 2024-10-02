using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mover : MonoBehaviour
{
	[SerializeField] float xAngle = 0;
	[SerializeField] float yAngle = 0;
	[SerializeField] float zAngle = 0;

	[SerializeField] int moveSpeed = 10;
	private int originalSpeed;
	const float yValue = 0f;
	public int levelSelect;

	void Start()
	{
		PrintInstructions();
		originalSpeed = moveSpeed;
	}

	void FixedUpdate()
	{
		MovePlayer();
	}

	void PrintInstructions()
	{
		Debug.Log("Welcome to Roger and Out!");
		Debug.Log("Roger is lost and needs your help.");
		Debug.Log("You need to guide Roger out of the technological jungle of Scraptopia! ");
		Debug.Log("Use WASD to move Roger.");
		Debug.Log("Try not to hit the obstacles, they'll give Roger a shock!");
	}

	//Moves the player according to moveSpeed
	void MovePlayer()
	{
		float xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		transform.Translate(xValue, yValue, zValue);
		if (Input.GetAxis("Vertical") <0 && Input.GetAxis("Horizontal") == 0)
        {
			//Look Down
        }
		if(Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") == 0)
        {
			//Look Up
		}
		if(Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") < 0)
        {
			//Look Right
		}
		if(Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") > 0)
        {
			//Look Left
		}
		//Might need to do 8 directions rather than 4
	}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			originalSpeed = moveSpeed;
			moveSpeed = moveSpeed * 2;
        }
        else
        {
			moveSpeed = originalSpeed;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Water"))
		{
			SceneManager.LoadScene(levelSelect);
        }
    }

}
