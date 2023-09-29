using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joe : MonoBehaviour
{
    public GameObject background;
    public GameObject backgroundNEW;
    public GameObject script;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            background.active = false;
            backgroundNEW.active = true;
            script.active = true;
        }

    }

    


    
}
