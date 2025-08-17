using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfOcclusion : MonoBehaviour
{
    public GameObject rcontroller;
    public GameObject distanceObject;
    public float maxDistance = 20.0f;

    void Update()
    {   
        float delta = Vector3.Distance(rcontroller.transform.position, distanceObject.transform.position);
        if(delta >= maxDistance){
            disableObject(distanceObject);
        }
            else{
            enableObject(distanceObject);
        }
        
    }

    public void disableObject(GameObject gameObj){
        gameObj.GetComponent<Renderer>().enabled = false;
    }

    public void enableObject(GameObject gameObj){
        gameObj.GetComponent<Renderer>().enabled = true;
    }
}
