using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freedom : MonoBehaviour
{
    public GameController gameController;
    public GameObject panel;
    public GameObject Fredom;
    public AudioSource Cam;
    public GameObject Garage;
    public GameObject Rain;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {
            Fredom.SetActive(true);
            StartCoroutine(waiter());
            Cam.Stop();
            
            Rain.SetActive(false);

        }

    }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(13);
        panel.SetActive(true);
    }
}
