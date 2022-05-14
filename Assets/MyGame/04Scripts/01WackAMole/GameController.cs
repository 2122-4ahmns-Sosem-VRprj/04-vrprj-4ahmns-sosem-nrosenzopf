using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{

    public TextMeshPro timerText;
    public float gameTimer = 30f;
    public Hammer hammerscript;

    public GameObject moleContainer;
    public Mole[] moles;
    public float showMoleTimer = 1.5f;

    public int health = 3;
    public TextMeshPro healthText;

    public bool endReached = false;
    public Animator anim;
    public GameObject panel;

    private AudioSource sndEffect;


    void Start()
    {
        //moles = moleContainer
        // moles = moleContainer.GetComponentsInChildren<Mole>();
       moles = GetAllChildren(moleContainer);
        sndEffect = GetComponent<AudioSource>();

        Debug.Log("Anzahl Moles" + moles.Length);
       // anim.SetBool("DoorsUp", false);
    }

    // Update is called once per frame
    void Update()
    {
      //  healthText.text = "Health:" + health;
        gameTimer -= Time.deltaTime;

        if (gameTimer>1f)
        {
            // Macht das ich keine Kommazahlen mehr habe -> Mathf.Floor
            timerText.text = "Time:" + Mathf.Floor(gameTimer);

            healthText.text = "Tries:" + health;

            showMoleTimer -= Time.deltaTime;
            if (showMoleTimer < 0f)
            {
             
                moles[Random.Range(0, moles.Length)].ShowMole();

                showMoleTimer = 1.5f;
            }


        }

        else
        {
           if (hammerscript.scorethelux <= 10 && !endReached)
            {
                health = health - 1;
                healthText.text = "Tries:" + health;
                Debug.Log("Loooser");
                endReached = true;
                timerText.text = "Try again";
            }

         if (hammerscript.scorethelux > 10 && !endReached)
            {
                Debug.Log("Da soll i Gewinnen?");
                anim.SetBool("DoorsUp", true);
                sndEffect.Play();
                timerText.text = "You got it!";
              
            }

            /* else
             {
                 Debug.Log("irgentwas passt da net");
                 // Hier Tür Animation ausführen
             } */

          

            // timerText.text = "Game Over";
        }

        if (health <= 0)
        {
            timerText.text = "GameOver";
            panel.SetActive(true);

        }

    }

    public Mole[] GetAllChildren(GameObject parent)
    {
        Mole[] m = new Mole[parent.transform.childCount];
        
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            m[i] = parent.transform.GetChild(i).GetComponent<Mole>();
        }

        return m;
    }

    public void TimerNewBeimErstenMal()
    {
        if (health > 0 && gameTimer<1f)
        {
            gameTimer = 30f;
            timerText.text = "Time:" + Mathf.Floor(gameTimer);
            hammerscript.scorethelux = 0;
            endReached = false;
            
        }

      



    } 
}
