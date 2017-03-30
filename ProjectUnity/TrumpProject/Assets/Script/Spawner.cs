using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public Enemy enemy;
    public GameController controller;
    public float spawnTime = 3f;            
    public Transform spawnPoint;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        enemy.controller = controller;
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
