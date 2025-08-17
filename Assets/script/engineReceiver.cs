using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engineReceiver : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject dialougeSign;
    public AudioSource source;
    public AudioClip clip;
    public bool engineHasBeenDelivered = false;

    void OnTriggerEnter(Collider other){
        if ((other.gameObject.tag == "rotaryEngine")&&!engineHasBeenDelivered){
            other.gameObject.SetActive(false);
            source.PlayOneShot(clip);
            engineHasBeenDelivered = true;
            dialougeSign.SetActive(true);
        }
    }
}
