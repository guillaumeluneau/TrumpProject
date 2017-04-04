using UnityEngine;
using System.Collections;

public class SpawnBoss : MonoBehaviour
{

    public Boss boss;
    public GameController controller;
    public Transform spawnPoint;
    public GameObject sound;

    // Use this for initialization
    void Start()
    {
    
    }

    void Update()
    {
        if (controller.score == 10)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        boss.controller = controller;
        Instantiate(boss, spawnPoint.position, spawnPoint.rotation);
        controller.score = 5;
        sound.GetComponent<AudioSource>().Play();
    }
}
