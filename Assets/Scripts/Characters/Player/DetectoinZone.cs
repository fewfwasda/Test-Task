using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectoinZone : MonoBehaviour
{
    static public bool Run = true;

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Run = false;
        }
        else
        {
            Run = true;
        }
    }
}