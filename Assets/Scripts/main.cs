using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class main : MonoBehaviour {

	public int score;

	public Text scoreboard;

	void Start () {
		
		score = 0;

		scoreboard.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public void ScoreAdd()
	{
		score++;
		scoreboard.text = score.ToString();
	}
}
