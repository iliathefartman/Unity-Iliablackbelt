using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disapear : MonoBehaviour
{
    public GameObject item;
    public GameObject perm;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            item.active = false;
            perm.active = true;
        }

    }
}
