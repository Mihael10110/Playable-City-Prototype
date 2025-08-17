using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkMan : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "walkMan")
        {
                source.PlayOneShot(clip);
        }
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "walkMan")
        {
            source.Stop();
        }
    }
}
