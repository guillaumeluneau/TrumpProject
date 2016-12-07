using UnityEngine;
using System.Collections;

public class Ennemi : MonoBehaviour {

    private Vector3 pointA;
    public Transform pointB;
    private float speed = 1;

	// Use this for initialization
	void Start () {

        pointA = transform.position;

        while (true)
        {
            var i = Mathf.PingPong(Time.time * speed, 1);
            transform.position = Vector3.Lerp(pointA, pointB.position, i);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
