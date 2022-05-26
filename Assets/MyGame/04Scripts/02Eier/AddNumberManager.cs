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

    public Animator anim;

    private void Start()
    {
        zahl1 = Random.Range(0, 9);
        zahl2 = Random.Range(0, 9);
        zahl3 = Random.Range(0, 9);

        textZahl1.text = zahl1.ToString();
        textZahl2.text = zahl2.ToString();
        textZahl3.text = zahl3.ToString();
  

    }

    public void Update()
    {
        CheckCode();
    }


    public void CheckCode()
    {
        if (zahl1 == 7 && zahl2 == 3 && zahl3 == 8)
        {
            // Ziel erreicht
            Debug.Log("Jetzt fallst nieder!!!");

            anim.SetBool("Egg", true);

        }
    } 

}

