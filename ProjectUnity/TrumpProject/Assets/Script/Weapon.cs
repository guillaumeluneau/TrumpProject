using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    public GameObject bullet;

    private PlayerMovement playermovement;
    public GameObject shoot;

    public GameObject turret;

    public GameObject turretPlacement;


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
            shoot.GetComponent<AudioSource>().Play();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if(playermovement.turret >= 1)
            {
                if (playermovement.PlayerDirection == Direction.LEFT)
                {
                    turret.transform.rotation = new Quaternion(-0, 180, 0, 0);
                }
                else
                {
                    turret.transform.rotation = new Quaternion(0, 0, 0, 0);
                }

                var tTurret = Instantiate(turret, gameObject.transform.position, turret.transform.rotation) as GameObject;
                tTurret.GetComponent<Turret>().turretDirection = playermovement.PlayerDirection;
                turretPlacement.GetComponent<AudioSource>().Play();

                playermovement.turret += -1;

            }

        }
    }

   
}
