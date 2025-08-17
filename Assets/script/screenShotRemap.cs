using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenShotRemap : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            source.PlayOneShot(clip);
        }
    }
}
