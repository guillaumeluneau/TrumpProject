using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {
    public GameObject turret;
    public GameObject bullet;
    public GameObject shoot;
    public Direction turretDirection = Direction.RIGHT;
    public float spawnTime = 0.1f;
    public float lifeSpan = 10f;
    public float timeStart;

    private PlayerMovement playermovement;
    private Transform _transform;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        _transform = transform;
        timeStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time - timeStart >= lifeSpan)
        {
            Destroy(gameObject);
        }
    }

    void Spawn()
    {
        var tBullet = Instantiate(bullet, gameObject.transform.position, bullet.transform.rotation) as GameObject;
        tBullet.GetComponent<Bullet>().bulletDirection = turretDirection;
        turret.GetComponent<AudioSource>().Play();
    }

    private void Flip()
    {

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
