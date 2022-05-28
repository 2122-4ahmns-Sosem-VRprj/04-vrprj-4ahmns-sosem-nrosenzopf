using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoors : MonoBehaviour
{
    public Animator animLeft;
    public Animator animRight;
    public GameObject SoundBox;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {
            Debug.Log("DoorsClosed");
            animLeft.SetBool("CloseLeft", true);
            animRight.SetBool("CloseRight", true);
            SoundBox.SetActive(true);
           
        }
    }

    
}


