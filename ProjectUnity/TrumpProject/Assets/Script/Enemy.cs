using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public int health = 50;
    public GameObject sound;
    public GameController controller;

    public void Damage(int dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            sound.GetComponent<AudioSource>().Play();
            controller.AddScore(1);
            controller.UpdateScore();
            Destroy(gameObject);
        }

    }
}
