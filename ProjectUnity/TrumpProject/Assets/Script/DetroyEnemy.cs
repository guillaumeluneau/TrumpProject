using UnityEngine;
using System.Collections;

public class DetroyEnemy : MonoBehaviour
{

    public GameObject sound;
    public GameController controller;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            sound.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            controller.AddScore(-1);
            controller.UpdateScore();
        }
    }
}