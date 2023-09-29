using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheep : MonoBehaviour
{
    public GameObject Sheep;
    public GameObject wall;
    public GameObject exit;
    public GameObject invupdate;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            invupdate.active = true;
            exit.active = true;
            wall.active = false;
            Sheep.active = false;
            
            
            

            print("sheep has been found!!!");
        
        }

    }
}
