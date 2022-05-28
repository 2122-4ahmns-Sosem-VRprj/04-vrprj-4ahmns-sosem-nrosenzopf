using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftButton : MonoBehaviour
{
    public Animator ButtonUp;
    public Animator Open;
    public Animator OpenR;
    public GameObject SoundBox;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {
            Debug.Log("LiftUp");
            ButtonUp.SetBool("LiftUp", true);
            Open.SetBool("DoorUpLeft", true);
            OpenR.SetBool("DoorUpRight", true);
            SoundBox.SetActive(true);
            StartCoroutine(waiter());

        }

        IEnumerator waiter()
        {
            yield return new WaitForSecondsRealtime(4);
            SoundBox.SetActive(false);
    }
    }
}
