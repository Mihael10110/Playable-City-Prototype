using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionUFO : MonoBehaviour
{
    public GameObject renderObjectOne;
    public GameObject renderObjectTwo;
    public GameObject renderObjectThree;
    //public GameObject renderObjectFour;
    public GameObject renderObjectFive;
    public GameObject renderObjectSix;
    public AudioSource source;
    public AudioClip clip;

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "ufoCrash")
        {
            renderObjectOne.SetActive(true);
            source.PlayOneShot(clip);
        }
    }

    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "ufoCrash")
        {
            renderObjectOne.SetActive(false);
            renderObjectTwo.SetActive(true);
            renderObjectThree.SetActive(true);
            //renderObjectFour.SetActive(true);
            renderObjectFive.SetActive(true);
            renderObjectSix.SetActive(true);
        }  
    }

}
