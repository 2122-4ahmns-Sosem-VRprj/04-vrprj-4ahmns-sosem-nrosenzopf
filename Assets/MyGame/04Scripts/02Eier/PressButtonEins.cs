using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButtonEins : MonoBehaviour
{

    public AddNumberManager manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {


            if (manager.zahl1 < 9)
            {
                Debug.Log("EiTriggererer");
                manager.zahl1 = manager.zahl1 + 1;
                manager.textZahl1.text = manager.zahl1.ToString();
            }
            else
            {
                manager.zahl1 = 0;
                manager.textZahl1.text = manager.zahl1.ToString();
            }
        }
    }
}