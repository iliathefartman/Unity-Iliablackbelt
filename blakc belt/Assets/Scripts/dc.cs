using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dc : MonoBehaviour
{
    public GameObject background;
    public GameObject oldscript;
    public GameObject inventory;
    
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            background.active = true;
            oldscript.active = false;
            inventory.active = false;

            

        }
    }
}
