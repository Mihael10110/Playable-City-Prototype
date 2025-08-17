using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pictureCollision : MonoBehaviour
{
    public GameObject renderObjectOne;
    public GameObject renderObjectTwo;

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "picturePlace"){
            renderObjectOne.SetActive(true);
            renderObjectTwo.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other){
          if (other.gameObject.tag == "picturePlace"){
            renderObjectOne.SetActive(false);
            renderObjectTwo.SetActive(false);
        }  
    }
}
