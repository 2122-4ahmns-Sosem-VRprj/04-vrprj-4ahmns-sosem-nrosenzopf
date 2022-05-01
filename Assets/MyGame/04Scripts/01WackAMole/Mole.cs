using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public float visibleYHeight = 2.0f;
    public float hiddenYHeight = -1.6f;
    private Vector3 myNextXYZPosition;
    public float speed = 4f;
    public float hideMoleTImer = 1.5f;

    void Awake()
    {
        HideMole();

        transform.localPosition = myNextXYZPosition;


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Vector3.Lerp( transform.localPosition, myNextXYZPosition, Time.deltaTime*speed ) ;

        hideMoleTImer -= Time.deltaTime;
        if (hideMoleTImer < 0)
        {
            HideMole();
        }
    }

    public void HideMole()
    {
        myNextXYZPosition = new Vector3(transform.localPosition.x, hiddenYHeight, transform.localPosition.z);
    }

    public void ShowMole()
    {
        myNextXYZPosition = new Vector3(
            transform.localPosition.x, visibleYHeight, transform.localPosition.z);
        hideMoleTImer = 1.5f;

        

    }  
    
    
    
    
   
}
