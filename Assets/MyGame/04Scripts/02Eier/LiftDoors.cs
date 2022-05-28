using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftDoors : MonoBehaviour
{
    public Animator animLeft;
    public Animator animRight;
    public GameObject SoundBox;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {
            Debug.Log("DoorOpen");
            animLeft.SetBool("DoorLeft", true);
            animRight.SetBool("DoorRight", true);
            SoundBox.SetActive(true);


        }
    }




        }
