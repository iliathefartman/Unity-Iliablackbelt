using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Starts : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
