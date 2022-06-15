using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameController controllerscript;
   


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EiTrigger"))
        {
            Debug.Log("Hallo");
            controllerscript.enabled = true;

            if (controllerscript.health > 0 && controllerscript.gameTimer < 1f)
            {
                controllerscript. gameTimer = 50f;
                controllerscript.timerText.text = "Time:" + Mathf.Floor(controllerscript.gameTimer);
                controllerscript.hammerscript.scorethelux = 0;
                controllerscript.endReached = false;

            }
        }

            

    }
}
