using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nectd : MonoBehaviour
{
    



    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(5);

        }

    }
}
