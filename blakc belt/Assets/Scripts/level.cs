using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(7);
        print("Nice!");
    }

    void Start()
    {
        Cursor.visible = true;
    }
}
