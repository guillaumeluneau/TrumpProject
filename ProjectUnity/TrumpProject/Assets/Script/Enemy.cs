using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public int health = 50;
    public GameObject sound;

    public void Damage(int dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            sound.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }

    }
}
