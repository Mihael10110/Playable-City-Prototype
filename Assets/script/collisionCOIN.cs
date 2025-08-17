using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCOIN : MonoBehaviour
{
    public GameObject renderObjectOne;
    public AudioSource source;
    public AudioClip clip;

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "well")
        {
            renderObjectOne.SetActive(true);
            source.PlayOneShot(clip);
        }
    }
}
