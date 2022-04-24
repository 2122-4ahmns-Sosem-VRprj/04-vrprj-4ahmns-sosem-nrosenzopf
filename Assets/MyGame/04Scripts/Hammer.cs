using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hammer : MonoBehaviour
{

 
    public int score = 0;
    [SerializeField]
    private TextMeshPro scoreText;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Mole")
        {
            Debug.Log("Du hast des Mole gehittet");
        }

        UpdateScore();

        Mole moleIhit = collision.gameObject.transform.GetComponent<Mole>();
        moleIhit.HideMole();
    }


    void UpdateScore()
    {
        score++;
        scoreText.text = "Score:" + score;


    }
}
