using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkor : MonoBehaviour
{
    public GameObject item;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            item.active = false;


        }

    }
}
