using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Blade : MonoBehaviour
{
	public int levelSelect = 4;
	private void OnCollisionEnter(Collision collision)
	{
		
		//On collision with player returns player to "Hub" scene
		if (collision.gameObject.CompareTag("Player"))
		{
			SceneManager.LoadScene(levelSelect);
		}
	}
}
