using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NXTscene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(8);
        
    }
}
