using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scre : MonoBehaviour
{
    public GameObject script;
    public GameObject oldscript;
    public GameObject Inventory;
    public GameObject Screwdriver;
    public GameObject item;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Inventory.active = true;
            oldscript.active = false;
            script.active = true;
            Screwdriver.active = false;
            item.active = false;
            
            

            print("Screwdriver Picked Up");
        
        }

    }
}
