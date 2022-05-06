using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EiGelb : MonoBehaviour
{
    public GameObject EiGelbinCanvas;
    public GameObject EiGrauGelbinCanvas;
    public AudioSource Audio;
    public AudioClip Clip;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "EiTrigger")
        {
            Debug.Log("Osterei");
            Destroy(gameObject);
            EiGelbinCanvas.SetActive(true);
            EiGrauGelbinCanvas.SetActive(false);
            Audio.PlayOneShot(Clip);

        }


        // ICH BRAUCHE TRIGGER

    }
}
