using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class boomWhackerSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clipOne;
    public AudioClip clipTwo;
    public AudioClip clipThree;
    public AudioClip clipFour;
    public AudioClip clipFive;
    public AudioClip clipSix;
    public AudioClip clipSeven;
    public AudioClip clipEight;

    public GameObject blueManAnimationOne;
    public GameObject blueManAnimationTwo;
    public GameObject blueManAnimationThree;
    public GameObject blueManRenderOne;
    public GameObject blueManRenderTwo;
    public GameObject blueManRenderThree;
    public GameObject dancingManRenderer;
    public GameObject starManRenderOne;
    public GameObject starManRenderTwo;
    public GameObject blueLightRenderOne;
    public GameObject blueLightRenderTwo;
    public GameObject greenLightRenderOne;
    public GameObject greenLightRenderTwo;
    public GameObject redLightRenderOne;
    public GameObject redLightRenderTwo;
    private bool blueLight = true;
    private bool greenLight = false;
    public bool starMan = false;
    public bool dancer = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "boxOne")
        {
            source.PlayOneShot(clipOne);
            switchLight();
        }
        if (other.gameObject.tag == "boxTwo")
        {
            source.PlayOneShot(clipTwo);
            switchLight();
        }
        if (other.gameObject.tag == "boxThree")
        {
            source.PlayOneShot(clipThree);
            switchLight();
        }
        if (other.gameObject.tag == "boxFour")
        {
            source.PlayOneShot(clipFour);
            switchLight();
        }
        if (other.gameObject.tag == "boxFive")
        {
            source.PlayOneShot(clipFive);
            switchLight();
        }
        if (other.gameObject.tag == "boxSix")
        {
            source.PlayOneShot(clipSix);
            switchLight();
        }
        if (other.gameObject.tag == "boxSeven")
        {
            source.PlayOneShot(clipSeven);
            switchLight();
        }
        if (other.gameObject.tag == "boxEight")
        {
            source.PlayOneShot(clipEight);
            switchLight();
        }
        if (other.gameObject.tag == "switchBox")
        {
            switchShow();
        }
    }

    public void switchShow()
    {
        if (dancer)
        {
            blueManRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            blueManRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            blueManRenderThree.gameObject.GetComponent<Renderer>().enabled = false;
            dancingManRenderer.gameObject.GetComponent<Renderer>().enabled = false;
            dancer = false;
            starManRenderOne.gameObject.GetComponent<Renderer>().enabled = true;
            starManRenderTwo.gameObject.GetComponent<Renderer>().enabled = true;
            starMan = true;
            return;
        }
        else if (starMan)
        {
            dancingManRenderer.gameObject.GetComponent<Renderer>().enabled = false;
            starManRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            starManRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            starMan = false;
            blueManRenderOne.gameObject.GetComponent<Renderer>().enabled = true;
            blueManRenderTwo.gameObject.GetComponent<Renderer>().enabled = true;
            blueManRenderThree.gameObject.GetComponent<Renderer>().enabled = true;
            return;
        }
        else
        {
            starManRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            starManRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            dancingManRenderer.gameObject.GetComponent<Renderer>().enabled = true;
            dancer = true;
            blueManRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            blueManRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            blueManRenderThree.gameObject.GetComponent<Renderer>().enabled = false;
            return;
        }
    }

    public void switchLight()
    {
        if (blueLight)
        {
            blueLightRenderOne.gameObject.GetComponent<Renderer>().enabled = true;
            blueLightRenderTwo.gameObject.GetComponent<Renderer>().enabled = true;
            greenLightRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            greenLightRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            redLightRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            redLightRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            blueLight = false;
            greenLight = true;
            return;
        }
        else if (greenLight)
        {
            blueLightRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            blueLightRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            greenLightRenderOne.gameObject.GetComponent<Renderer>().enabled = true;
            greenLightRenderTwo.gameObject.GetComponent<Renderer>().enabled = true;
            redLightRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            redLightRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            greenLight = false;
            return;
        }
        else
        {
            blueLightRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            blueLightRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            greenLightRenderOne.gameObject.GetComponent<Renderer>().enabled = false;
            greenLightRenderTwo.gameObject.GetComponent<Renderer>().enabled = false;
            redLightRenderOne.gameObject.GetComponent<Renderer>().enabled = true;
            redLightRenderTwo.gameObject.GetComponent<Renderer>().enabled = true;
            blueLight = true;
            return;
        }
    }
}
