using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCounter : MonoBehaviour
{
    public int numberOfCheckpoints;
    public int triggeredCheckpoints;

    void Start()
    {
        numberOfCheckpoints = GameObject.FindGameObjectsWithTag("checkpoint").Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
