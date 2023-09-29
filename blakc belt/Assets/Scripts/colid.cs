using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colid : MonoBehaviour
{
    public GameObject background;
    public GameObject OldScript;
    public GameObject NewScript;
    public GameObject inventory;
    public GameObject john;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

            background.active = true;
            OldScript.active = false;
            NewScript.active = true;
            inventory.active = false;
            john.active = true;


        }
    }
}
