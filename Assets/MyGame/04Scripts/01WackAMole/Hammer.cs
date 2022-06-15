using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hammer : MonoBehaviour
{

    public int scorethelux = 0;
    //public int score;
    [SerializeField]
    private TextMeshPro scoreText;
    private AudioSource sndEffect;

    public void Start()
    {
        //scorethelux = 0;
        sndEffect = GetComponent<AudioSource>();
    }

   private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Mole")
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
        sndEffect.Play();
        scoreText.text = "Score:" + scorethelux;

    }
}
