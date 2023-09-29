using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK : MonoBehaviour
{
    public GameObject background;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            background.active = false;
        }

    }
}
