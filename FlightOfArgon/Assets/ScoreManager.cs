using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {
    Text scoreText;
    int score = 0;
	// Use this for initialization
	void Start () {
        scoreText = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AddScore()
    {
        score += 100;
        scoreText.text = "Score: " + score;
        Debug.Log("Score + " + score);
    }
}
