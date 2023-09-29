using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fina : MonoBehaviour
{
    public GameObject script;
    public GameObject background;
    public GameObject oldScript;
    public GameObject Portal;
    public GameObject Inventory;
    public GameObject In1;
    public GameObject In2;


    void OnTriggerEnter(Collider other)
    {
    
        if(other.gameObject.CompareTag("Player"))
        {
            Inventory.active = false;
            oldScript.active = false;
            background.active = true;
            Portal.active = true;
            script.active = true;
            In1.active = false;
            In2.active = false;
        }

    }
}
