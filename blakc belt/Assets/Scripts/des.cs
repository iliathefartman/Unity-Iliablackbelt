using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class des : MonoBehaviour
{
    public GameObject phone;
    public GameObject Script;
    public GameObject Inventory;
    public GameObject InteractScript;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            Script.active = false;
            Destroy(phone);
            Inventory.active = true;
            InteractScript.active = true;

            print("Can Picked Up");
        
        }

        }
    }
