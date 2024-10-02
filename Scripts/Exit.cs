using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Exit : MonoBehaviour
{
	public TMP_Text txt;
	public hitstore hitSt;
	public Timer timer;
	public Canvas canvas;

	float Score;
	float time;
	public float hits;
	[SerializeField] int levelSelect;
    private void Start()
    {
		canvas.GetComponent<Canvas>().enabled = false; 
    }
    private void OnCollisionEnter(Collision collision)
	{
		//On collision with player brings up "Win Screen" 
		if (collision.gameObject.CompareTag("Player"))
		{
			canvas.GetComponent<Canvas>().enabled = true;
			Debug.Log("Victory!");
			Time.timeScale = 0;

			time = timer.GetComponent<Timer>().time;
			hits = hitSt.GetComponent<hitstore>().hits;
			
			//Calculates final Score

			Score = 1000 - (time * (hits*hits));
			if(Score <= 0)
            {
				Score = 0;
            }
			txt.text = $"Score : {Mathf.Round(Score)}";
		}

	}
	public void nextLevel()
    {
		SceneManager.LoadScene(levelSelect + 1);
		Time.timeScale = 1;
    }
	public void Replay()
    {
		SceneManager.LoadScene(levelSelect);
		Time.timeScale = 1;
    }
	public void End()
    {
		SceneManager.LoadScene(0);
		Time.timeScale = 1;
	}
}