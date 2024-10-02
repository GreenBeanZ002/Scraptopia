using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int levelSelect;

    private void OnCollisionEnter(Collision collision)
    {
        //Opens the selected level on collision with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(levelSelect+1);
        }
    }
}
