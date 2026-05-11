using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Exit : MonoBehaviour
{
	public TMP_Text txt;
	public TMP_Text promptTxt;
	public hitstore hitSt;
	public Timer timer;
	public Canvas canvas;

	float Score;
	float time;
	public float hits;
	[SerializeField] int levelSelect;
    [SerializeField] int levelSelectPrompt;
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
			pickExitPopup(hits);
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

	private void pickExitPopup(float hitCount)
	{
		switch (hitCount)
		{
			case 0:
				if (levelSelectPrompt == 7)
				{
					promptTxt.text = "Perfect! Congratulations for beating the game!";
					return;
				}
				else
				{
                    promptTxt.text = "Perfect! can you beat the next level?";
                    return;
                }
					
			case 1:
				promptTxt.text = "Almost perfect! Try again!";
				return;
			case 2:
				promptTxt.text = "Only hit twice! See if you can beat your score!";
				return;
			case 3:
				promptTxt.text = "Good effort! Now aim higher!";
				return;
			default:
				promptTxt.text = "Keep practising - you can do better! Try again to get a higher score!"; 
				return;//Improve your score next time! Click Play again for another try
		}

	}
}