using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EiGruen : MonoBehaviour
{
    public GameObject EiGrueninCanvas;
    public GameObject EiGrauGrueninCanvas;
    public AudioSource Audio;
    public AudioClip Clip;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "EiTrigger")
        {
            Debug.Log("Osterei");
            Destroy(gameObject);
            EiGrueninCanvas.SetActive(true);
            EiGrauGrueninCanvas.SetActive(false);
            Audio.PlayOneShot(Clip);

        }


        // ICH BRAUCHE TRIGGER

    }
}
