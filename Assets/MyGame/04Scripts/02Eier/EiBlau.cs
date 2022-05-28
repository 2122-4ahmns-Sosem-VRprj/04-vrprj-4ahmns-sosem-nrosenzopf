using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EiBlau : MonoBehaviour
{
    public GameObject EiBlauinCanvas;
    public GameObject EiGrauBlauinCanvas;
    public AudioSource Audio;
    public AudioClip Eight;

    public AudioClip impact;
    AudioSource audioSource;
    public GameObject SoundBox;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "EiTrigger")
        {
            Debug.Log("Osterei");
            Destroy(gameObject);
            EiBlauinCanvas.SetActive(true);
            EiGrauBlauinCanvas.SetActive(false);
            // audioSource.PlayOneShot(impact, 0.7F);
            SoundBox.SetActive(true);

        }


        // ICH BRAUCHE TRIGGER

    }
}
