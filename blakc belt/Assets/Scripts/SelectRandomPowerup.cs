﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    
    public int randomNumberInList;
    public GameObject chosenPowerup;


    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
        {
            GameObject chosenPowerupClone = Instantiate(chosenPowerup, transform.position, transform.rotation);
        }
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "itemBoxes"){
            
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
