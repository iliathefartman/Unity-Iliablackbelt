using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide1 : MonoBehaviour
{
    public GameObject item;
    public GameObject inventory;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            item.active = false;
            inventory.active = true;



        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            item.active = true;
            inventory.active = false;


        }

    }
}
