using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    public GameObject background;
    public GameObject newscript;




    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            background.active = true;
            newscript.active = true;


        }
    }
}
