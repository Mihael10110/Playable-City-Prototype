using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinWithController : MonoBehaviour
{
    public GameObject gameOdject;
    public int rotationOfset = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 controlRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch).eulerAngles;
        Quaternion newRotation = Quaternion.Euler(controlRotation.z+rotationOfset,0,90);
        gameOdject.transform.rotation = newRotation;
    }
}
