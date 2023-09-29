using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    public GameObject item;
   



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            item.active = true;
        }

    }
}
