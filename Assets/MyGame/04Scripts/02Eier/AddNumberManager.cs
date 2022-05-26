using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddNumberManager : MonoBehaviour
{
    public int zahl1;
    public int zahl2;
    public int zahl3;

    public TextMeshPro textZahl1;
    public TextMeshPro textZahl2;
    public TextMeshPro textZahl3;

    public GameObject anim;

    private void Start()
    {
        zahl1 = Random.Range(0, 9);
        zahl2 = Random.Range(0, 9);
        zahl3 = Random.Range(0, 9);

        textZahl1.text = zahl1.ToString();
        textZahl2.text = zahl2.ToString();
        textZahl3.text = zahl3.ToString();
  

    }



    private void OnTriggerEnter(Collider other)
    {
      
            if (zahl1 < 9)
            {
                zahl1 = zahl1 + 1;
                textZahl1.text = zahl1.ToString();
            }
            else
            {
                zahl1 = 0;
                textZahl1.text = zahl1.ToString();
            }

        

            if (zahl2 < 9)
            {
                zahl2 = zahl2 + 1;
                textZahl2.text = zahl2.ToString();
            }
            else
            {
                zahl2 = 0;
                textZahl2.text = zahl2.ToString();
            }

 
        
            if (zahl3 < 9)
            {
                zahl3 = zahl3 + 1;
                textZahl3.text = zahl3.ToString();
            }
            else
            {
                zahl3 = 0;
                textZahl3.text = zahl3.ToString();
            }

        

        CheckCode();

    }

    public void CheckCode()
    {
        if (zahl1 == 7 && zahl2 == 3 && zahl3 == 8)
        {
            // Ziel erreicht
            Debug.Log("Gewonnen!!!");

            //Play Anim

        }
    }

}

