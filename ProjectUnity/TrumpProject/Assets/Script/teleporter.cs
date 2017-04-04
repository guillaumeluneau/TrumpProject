 using UnityEngine;
 using System.Collections;
 
 public class teleporter : MonoBehaviour
 {
    //this is the exit object
    public Transform exit;
    public GameObject portalsound;

    public GameController controller;


    //teleporte l'objet qui rentre dans le portail
    void OnTriggerEnter2D(Collider2D other)
     {

        if (other.gameObject.tag == "Player")
        {
            other.transform.position = exit.position;
            portalsound.GetComponent<AudioSource>().Play();

            controller.AddScore(-50);
            controller.UpdateScore();
        }
        
     }
 }