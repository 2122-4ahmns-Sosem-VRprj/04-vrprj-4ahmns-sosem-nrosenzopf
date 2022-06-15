using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainaus : MonoBehaviour
{
    public GameObject rain;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "EiTrigger")
        {
            Destroy(rain);
        }
    }
}
