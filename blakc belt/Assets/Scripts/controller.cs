using UnityEngine;
using UnityEngine.SceneManagement;
 
public class controller : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(3);
    }
}
