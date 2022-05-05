using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eier : MonoBehaviour
{
    public GameObject EiRotinCanvas;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            Debug.Log("Osterei");
            Destroy(gameObject);
            EiRotinCanvas.SetActive(true);

        }


        // ICH BRAUCHE TRIGGER

    }
}
