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
    public TextMesh healthText;

    public int thathealth;

    // Start is called before the first frame update


    void Start()
    {
        //moles = moleContainer
        // moles = moleContainer.GetComponentsInChildren<Mole>();
       moles = GetAllChildren(moleContainer);

            Debug.Log("Anzahl Moles" + moles.Length);
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

            
           showMoleTimer -= Time.deltaTime;
            if (showMoleTimer < 0f)
            {
             
                moles[Random.Range(0, moles.Length)].ShowMole();

                showMoleTimer = 1.5f;
            }


        }

        else
        {
            if (hammerscript.score <= 20)
            {
                thathealth =health - 1;
                Debug.Log("Loooser");
            }

            else
            {
                Debug.Log("WinnerWinnerChickenDinner");
            }


            // timerText.text = "Game Over";
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
}
