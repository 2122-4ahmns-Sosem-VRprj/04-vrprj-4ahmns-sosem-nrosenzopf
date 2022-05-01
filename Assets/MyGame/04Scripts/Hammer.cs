using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hammer : MonoBehaviour
{

    public int scorethelux;
    //public int score;
    [SerializeField]
    private TextMeshPro scoreText;

    public void Start()
    {
        scorethelux = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Mole")
        {
            Debug.Log("Du hast des Mole gehittet");

            UpdateScore();

            Mole moleIhit = collision.gameObject.transform.GetComponent<Mole>();
            moleIhit.HideMole();
        }

        
    }


    void UpdateScore()
    {
        scorethelux++;
        scoreText.text = "Score:" + scorethelux;
       

    }
}
