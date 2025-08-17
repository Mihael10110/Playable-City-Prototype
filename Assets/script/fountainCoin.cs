using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fountainCoin : MonoBehaviour
{
    public GameObject rotaryEngine;
    public AudioSource source;
    public AudioClip clip;

    public bool coinHasBeenDelivered = false;

    void OnTriggerEnter(Collider other){
        if ((other.gameObject.tag == "coinQuest")&&!coinHasBeenDelivered){
            rotaryEngine.SetActive(true);
            other.gameObject.SetActive(false);
            source.PlayOneShot(clip);
            coinHasBeenDelivered = true;
        }
    }
}
