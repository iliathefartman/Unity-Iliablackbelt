using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;

    public int numberOfBoxes;
    public int modifyXPosition;
    public int modifyZPosition;
    void Start()
    {
        createItemBoxes(numberOfBoxes);
    }

    void createItemBoxes(int maxItemBoxes){
        for(int i = 0; i < maxItemBoxes; i++){
            GameObject itemBoxClone = Instantiate(itemBox, new Vector3(transform.position.x + modifyXPosition * i, 
            transform.position.y, 
            transform.position.z + modifyZPosition * i),
            itemBox.transform.rotation);
        }
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
