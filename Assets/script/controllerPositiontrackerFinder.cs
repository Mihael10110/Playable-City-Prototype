using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class controllerPositiontrackerFinder : MonoBehaviour
{
    
    public GameObject controller;

    public GameObject testAid;


    // Update is called once per frame
    void Update()
    {
        var controllerPosition = controller.transform.position;

        testAid.transform.position = controllerPosition;
    }

}
