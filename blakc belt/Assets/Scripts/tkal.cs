using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tkal : MonoBehaviour
{
    public GameObject background;
    public GameObject Script;



    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            background.active = true;
            Script.active = true;

        }
    }
}
