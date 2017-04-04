using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    private Vector3 startMarker;
    private Vector3 endMarker;
    public float speed = 0.3F;
    public Vector3 posCurrent;
    public Vector3 posPrecedente;

    private float startTime;
    private float journeyLength;

    void Start()
    {
        startMarker = transform.position;
        endMarker = new Vector3(3, 1, 0);
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker, endMarker);
      

    }
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startMarker, endMarker, fracJourney);
        if(gameObject.transform.position.x > 0)
        {
            gameObject.transform.rotation = new Quaternion(-0, -180, 0, 0);
        }
    }
    
}

