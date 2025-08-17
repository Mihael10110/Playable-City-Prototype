using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximitySoundTrigger : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public GameObject distanceMeasureObject;
    private float minDistance = 6.0f;

    public bool isPlaying = false;

    void Update()
    {   
        Vector3 delta = distanceMeasureObject.transform.position - gameObject.transform.position;
        if(((delta.x>=minDistance)||(delta.z>=minDistance)||(delta.y>=minDistance))&&isPlaying){
            source.Stop();
        }
        else if(!isPlaying){
            source.PlayOneShot(clip);
        }
        
    }

    public void muteSound(){
        source.Stop();
    }
}
