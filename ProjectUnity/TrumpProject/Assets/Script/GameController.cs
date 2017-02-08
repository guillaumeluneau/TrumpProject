using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GUIText scoreText;
    public int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score" + score;
	}

    public void AddScore(int bonusScore)
    {
        score += bonusScore;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score" + score;
    }
}
