using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGameController : MonoBehaviour
{
    public GameController controllerscript;
  
    
   public void SetItActive ()
    {
        controllerscript.enabled = true;
    }
}
