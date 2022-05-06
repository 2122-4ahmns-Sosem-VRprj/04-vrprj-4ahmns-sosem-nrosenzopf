using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eier : MonoBehaviour
{
    public GameObject EiRotinCanvas;
    public GameObject EiGrauRotinCanvas;
    public AudioSource Audio;
    public AudioClip Clip;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "EiTrigger")
        {
            Debug.Log("Osterei");
            Destroy(gameObject);
            EiRotinCanvas.SetActive(true);
            EiGrauRotinCanvas.SetActive(false);
            Audio.PlayOneShot(Clip);
            
        }


        // ICH BRAUCHE TRIGGER

    }
}
