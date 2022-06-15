using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tot : MonoBehaviour
{
    public AudioSource sndEffect;
    public AudioSource Cam;
    public GameObject panel;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {
            Debug.Log("TriggerMitTot");
            Destroy(gameObject);
            panel.SetActive(true);
            Cam.Stop();

        }
    }
        }
