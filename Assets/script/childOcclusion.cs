using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childOcclusion : MonoBehaviour
{
    public GameObject rcontroller;
    public GameObject distanceObject;
    private GameObject[] childrenOfDistanceObject;
    private float maxDistance = 12.0f;

    void Start(){
        childrenOfDistanceObject = new GameObject[distanceObject.transform.childCount];

        for(int i = 0; i<=distanceObject.transform.childCount;i++){
            childrenOfDistanceObject[i] = distanceObject.transform.GetChild(i).gameObject;
        }
    }
    void Update()
    {   
        foreach(GameObject children in childrenOfDistanceObject){
            Vector3 delta = rcontroller.transform.position - children.transform.position;
            if((delta.x>=maxDistance)||(delta.z>=maxDistance)||(delta.y>=maxDistance)){
                disableObject(children);
            }
            else{
                enableObject(children);
            }
        }
    }

    public void disableObject(GameObject gameObj){
        gameObj.GetComponent<Renderer>().enabled = false;
    }

    public void enableObject(GameObject gameObj){
        gameObj.GetComponent<Renderer>().enabled = true;
    }
}
