 using UnityEngine;
 using System.Collections;
 
 public class teleporter : MonoBehaviour
 {
    //this is the exit object
    public Transform exit;
    public GameObject portalsound;
 
     
     //teleporte l'objet qui rentre dans le portail
     void OnTriggerEnter2D(Collider2D other)
     {
        other.transform.position = exit.position;
        portalsound.GetComponent<AudioSource>().Play();
     }
 }