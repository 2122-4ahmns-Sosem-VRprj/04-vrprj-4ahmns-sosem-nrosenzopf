using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftButton : MonoBehaviour
{
    public Animator ButtonUp;
    public Animator Open;
    public Animator OpenR;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {
            Debug.Log("LiftUp");
            ButtonUp.SetBool("LiftUp", true);
            Open.SetBool("DoorUpLeft", true);
            OpenR.SetBool("DoorUpRight", true);
        }
    }
}
