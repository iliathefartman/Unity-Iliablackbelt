using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inter : MonoBehaviour
{
    public GameObject script;
    public GameObject oldscript;
    public GameObject background;
    public GameObject Inventory;
    public GameObject jef;
    public GameObject newjeff;
    


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Inventory.active = false;
            background.active = true;
            oldscript.active = false;
            script.active = true;
            jef.active = true;
            newjeff.active = true;
            

            
            
        
        }

    }
}
