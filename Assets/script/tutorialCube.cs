using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialCube : MonoBehaviour
{
    public GameObject renderObjectOne;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colliderCube")
        {
            renderObjectOne.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "colliderCube")
        {
            renderObjectOne.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
