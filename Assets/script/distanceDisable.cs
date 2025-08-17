using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceDisable : MonoBehaviour
{
    public GameObject affectedObject;
    public GameObject distanceObject;
    public GameObject rcontroller;
    public float maxDistance = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Vector3.Distance(rcontroller.transform.position, distanceObject.transform.position);
        if (delta >= maxDistance){
            disableObject();
        }
        else{
            enableObject();
        }
    }

    public void disableObject(){
        affectedObject.SetActive(false);
    }

    public void enableObject(){
        affectedObject.SetActive(true);
    }
}
