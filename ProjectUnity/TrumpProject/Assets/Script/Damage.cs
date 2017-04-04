using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {
    public Rigidbody2D rb2d;
    public GameObject sound;

	// Use this for initialization

	void Start () {
        
	
	}

    public IEnumerator Knockback(float knockDur, float knockbackPwr, Vector3 knockbackDir)
    {
        float timer = 0;
        while (knockDur > timer)
        {
            timer += Time.deltaTime;
            rb2d.AddForce(new Vector3(knockbackDir.x * +100, knockbackDir.y * knockbackPwr, transform.position.z));
        }
        yield return 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //player_controller player = col.GetComponentInParent<GameObject>().GetComponent<player_controller>();

        //player.Rpc_Damage(3);
        if (col.CompareTag("Player"))
        {
            sound.GetComponent<AudioSource>().Play();
            StartCoroutine(Knockback(0.02f, 30, col.transform.position));
        }
 
        
    }
}
