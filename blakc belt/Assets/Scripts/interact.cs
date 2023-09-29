using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public GameObject script;
    public GameObject Background;
    public GameObject Inventory;
    public GameObject Screwdriver;
    public GameObject oldscript;
    public GameObject sssce;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Inventory.active = false;
            oldscript.active = false;
            Background.active = true;
            script.active = true;
            Screwdriver.active = true;
            sssce.active = true;

            
            
        
        }

    }
}
