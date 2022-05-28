using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenDestroy : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(6);
        Destroy(gameObject);
    }
}