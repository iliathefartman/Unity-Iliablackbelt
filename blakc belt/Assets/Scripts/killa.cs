using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision other)
        {if(other.gameObject.tag == "item")
            {
                Destroy(this);
            
            
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                
                SceneManager.LoadScene(0);
            
            
            }
        }
}
