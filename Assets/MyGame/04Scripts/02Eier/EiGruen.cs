using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EiGruen : MonoBehaviour
{
    public GameObject EiGrueninCanvas;
    public GameObject EiGrauGrueninCanvas;



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "EiTrigger")
        {
            Debug.Log("Osterei");
            Destroy(gameObject);
            EiGrueninCanvas.SetActive(true);
            EiGrauGrueninCanvas.SetActive(false);
 

        }


        // ICH BRAUCHE TRIGGER

    }
}
