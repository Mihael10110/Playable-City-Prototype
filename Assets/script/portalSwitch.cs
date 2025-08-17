using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalSwitch : MonoBehaviour
{
    public GameObject leverObject;
    public GameObject imageOne;
    public GameObject imageTwo;
    public GameObject imageThree;
    public GameObject imageFour;
    public GameObject imageFive;
    public GameObject imageSix;
    public GameObject imageSeven;

    private int count = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lever")
        {
            count++;
            spinTheLever(true);
            if (count == 1)
            {
                imageOne.SetActive(false);
                imageTwo.SetActive(true);
            }
            else if (count == 2)
            {
                imageTwo.SetActive(false);
                imageThree.SetActive(true);
            }
            else if (count == 3)
            {
                imageThree.SetActive(false);
                imageFour.SetActive(true);
            }
            else if (count == 4)
            {
                imageFour.SetActive(false);
                imageFive.SetActive(true);
            }
            else if (count == 5)
            {
                imageFive.SetActive(false);
                imageSix.SetActive(true);
            }
            else if (count == 6)
            {
                imageSix.SetActive(false);
                imageSeven.SetActive(true);
            }
            else
            {
                imageSeven.SetActive(false);
                imageOne.SetActive(true);
                count = 0;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "lever")
        {
            spinTheLever(false);
        }
    }

    public void spinTheLever(bool positiveMovement)
    {
        if (positiveMovement)
        {
            leverObject.transform.rotation = Quaternion.Euler(-45, -90, 0);
        }
        else
        {
            leverObject.transform.rotation = Quaternion.Euler(45, -90, 0);
        }
    }
}
