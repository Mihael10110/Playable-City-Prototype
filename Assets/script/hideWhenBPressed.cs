using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideWhenBPressed : MonoBehaviour
{
    public GameObject gameObjectOne;
    public GameObject gameObjectTwo;

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            gameObjectOne.SetActive(false);
            gameObjectTwo.SetActive(false);
        }
    }
}
