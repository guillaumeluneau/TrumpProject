using UnityEngine;
using System.Collections;


public class Bonus : MonoBehaviour {

    public GameObject bonus;
    public Transform spawnpoint;
    public int respawndelay = 3;

    public GameObject sound;
    private PlayerMovement playermovement;

    void Start()
    {
        playermovement = GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            if (bonus.GetComponent<SpriteRenderer>().enabled == true)
            {

                col.gameObject.GetComponent<PlayerMovement>().AddTurret(1);
                StartCoroutine(RespawnBonus());
                sound.GetComponent<AudioSource>().Play();
            }
        }
    }

    public IEnumerator RespawnBonus()
    {
        bonus.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(3);
        bonus.GetComponent<SpriteRenderer>().enabled = true;

        yield return null;
    }
}
