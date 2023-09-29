using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide3 : MonoBehaviour
{
    public GameObject background;
    public GameObject inventory;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            background.active = false;
            inventory.active = true;



        }
        
    }
}
