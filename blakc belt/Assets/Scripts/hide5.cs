using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide5 : MonoBehaviour
{
    public GameObject background;
    public GameObject background1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            background.active = false;
            background1.active = true;



        }
        
    }
}
