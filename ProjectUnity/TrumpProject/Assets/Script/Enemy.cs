using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public GameObject enemy;
    public int health = 50;
    public GameController controller;

    public void Damage(int dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            enemy.GetComponent<AudioSource>().Play();
            controller.AddScore(1);
            controller.UpdateScore();
            Destroy(gameObject);
        }

    }
}
