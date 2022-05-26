using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButtonDrei : MonoBehaviour
{
    public AddNumberManager manager;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {
           

            if (manager.zahl3 < 9)
            {
                Debug.Log("EiTriggererer");
                manager.zahl3 = manager.zahl3 + 1;
                manager.textZahl3.text = manager.zahl3.ToString();
            }
            else
            {
                manager.zahl3 = 0;
                manager.textZahl3.text = manager.zahl3.ToString();
            }
        }
    }
}
