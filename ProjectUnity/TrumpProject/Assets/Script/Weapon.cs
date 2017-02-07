using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    public GameObject bullet;

    private PlayerMovement playermovement;
    public GameObject sound;

    // Use this for initialization
    void Start () {
        playermovement = GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            var tBullet = Instantiate(bullet, gameObject.transform.position, bullet.transform.rotation) as GameObject;
            tBullet.GetComponent<Bullet>().bulletDirection = playermovement.PlayerDirection;
            sound.GetComponent<AudioSource>().Play();
        }
	}
}
