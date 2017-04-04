using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GUIText scoreText;
    public int score;

    public GUIText lifeText;
    public int life;

    // Use this for initialization
    void Start () {
        score = 0;
        life = 10;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score : " + score;
        lifeText.text = "Vies : " + life;
    }

    public void AddScore(int bonusScore)
    {
        score += bonusScore;
        UpdateScore();
    }

   public void UpdateScore()
    {
        scoreText.text = "Score" + score;
    }

    public void AddLife(int bonusLife)
    {
        life += bonusLife;
        UpdateLife();
    }

    public void UpdateLife()
    {
        lifeText.text = "Vies : " + life;
    }
}
