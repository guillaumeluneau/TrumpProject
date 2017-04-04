using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {
    public GameObject boss;
    public int health = 50;
    public GameController controller;



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "shot")
        {
            health += -1;

            boss.GetComponent<AudioSource>().Play();
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    
}
