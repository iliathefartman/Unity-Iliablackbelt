using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkone : MonoBehaviour
{
    public GameObject script;
    public GameObject background;
    public GameObject wall;
    public GameObject oldScrip;
    public GameObject inventory;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            script.active = true;
            background.active = true;
            wall.active = false;
            oldScrip.active = false;
            inventory.active = false;
        
        }

    }
}
