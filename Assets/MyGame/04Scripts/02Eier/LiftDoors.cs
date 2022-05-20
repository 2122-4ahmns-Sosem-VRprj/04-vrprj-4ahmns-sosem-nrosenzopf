using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftDoors : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {
        // Hier spielt lift door animation
        
        }
    }




        }
