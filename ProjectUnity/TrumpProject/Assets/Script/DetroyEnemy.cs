using UnityEngine;
using System.Collections;

public class DetroyEnemy : MonoBehaviour
{

    public GameObject sound;
    public GameObject soundEnd;
    public GameController controller;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            sound.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            controller.AddLife(-1);
            controller.UpdateLife();
        }
        else if (other.gameObject.tag == "Boss")
        {
            soundEnd.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            controller.AddLife(-10);
            controller.UpdateLife();
        }
    }
}