using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EiBlau : MonoBehaviour
{
    public GameObject EiBlauinCanvas;
    public GameObject EiGrauBlauinCanvas;
    public AudioSource Audio;
    public AudioClip Clip;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "EiTrigger")
        {
            Debug.Log("Osterei");
            Destroy(gameObject);
            EiBlauinCanvas.SetActive(true);
            EiGrauBlauinCanvas.SetActive(false);
            Audio.PlayOneShot(Clip);

        }


        // ICH BRAUCHE TRIGGER

    }
}
