using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public Direction bulletDirection = Direction.RIGHT;
    public float speed = 5.0f;
    public float lifeSpan = 1.2f;
    public int damage = 5;
    public float timeStart;

    private Transform _transform;

    // Use this for initialization
    void Start()
    {
        _transform = transform;
        timeStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();

        if (Time.time - timeStart >= lifeSpan)
        {
            Destroy(gameObject);
        }
    }

    void MoveBullet()
    {
        int moveDirection = bulletDirection == Direction.LEFT ? -1 : 1;

        float translate = moveDirection * speed * Time.deltaTime;
        _transform.Translate(translate, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
            collision.collider.gameObject.GetComponent<Enemy>().Damage(damage);

        Destroy(gameObject);
    }
}
