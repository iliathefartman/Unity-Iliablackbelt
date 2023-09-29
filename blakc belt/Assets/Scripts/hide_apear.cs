using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide_apear : MonoBehaviour
{
    public GameObject background;
    public GameObject inventory;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            background.active = false;
            inventory.active = true;



        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            background.active = true;
            inventory.active = false;


        }

    }
}
