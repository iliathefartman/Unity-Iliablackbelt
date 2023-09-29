using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(5);
        print("Cool");
    }

    void Start()
    {
        Cursor.visible = true;
    }
}
