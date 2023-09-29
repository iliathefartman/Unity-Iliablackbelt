using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talk : MonoBehaviour
{
    public GameObject background;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            background.active = true;

        }
    }
    
}
