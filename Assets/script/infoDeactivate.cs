using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehainfoDeactivate : MonoBehaviour
{
    public GameObject renderObjectOne;
    public bool activeOnStart = false;

    public void infoState()
    {
        if (activeOnStart)
        {
            renderObjectOne.SetActive(false);
            activeOnStart = false;
        }
        else
        {
            renderObjectOne.SetActive(true);
            activeOnStart = true;
        }

    }
}
