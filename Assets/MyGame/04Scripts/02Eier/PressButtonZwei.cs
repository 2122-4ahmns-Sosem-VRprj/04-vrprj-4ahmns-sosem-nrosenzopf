using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButtonZwei : MonoBehaviour
{

    public AddNumberManager manager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {


            if (manager.zahl2 < 9)
            {
                Debug.Log("EiTriggererer");
                manager.zahl2 = manager.zahl2 + 1;
                manager.textZahl2.text = manager.zahl2.ToString();
            }
            else
            {
                manager.zahl2 = 0;
                manager.textZahl2.text = manager.zahl2.ToString();
            }
        }
    }
}
