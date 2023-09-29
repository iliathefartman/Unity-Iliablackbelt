using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide4 : MonoBehaviour
{
    public GameObject background;
    public GameObject newbackground;
    public GameObject newscript;
    public GameObject dis;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            background.active = false;
            newbackground.active = true;
            newscript.active = true;
            dis.active = true;

            



        }
        
    }
}
