using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingScene : MonoBehaviour
{
    private float movementScale = 0.25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Three))
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))
            {
                moveScene(true, true);
            }
            if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown))
            {
                moveScene(true, false);
            }
            if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft))
            {
                moveScene(false, true);
            }
            if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight))
            {
                moveScene(false, false);
            }
            if (OVRInput.Get(OVRInput.Button.One))
            {
                liftScene(true);
            }
            if (OVRInput.Get(OVRInput.Button.Two))
            {
                liftScene(false);
            }
        }
    }

    public void moveScene(bool targetAxisIsXnotY, bool forwardNotBackward)
    {
        Vector3 delta = gameObject.transform.position;
        if (targetAxisIsXnotY && forwardNotBackward)
        {
            gameObject.transform.position = new Vector3(delta.x, delta.y, delta.z + movementScale);
        }
        else if (targetAxisIsXnotY)
        {
            gameObject.transform.position = new Vector3(delta.x, delta.y, delta.z - movementScale);
        }
        else if (forwardNotBackward)
        {
            gameObject.transform.position = new Vector3(delta.x - movementScale, delta.y, delta.z);
        }
        else
        {
            gameObject.transform.position = new Vector3(delta.x + movementScale, delta.y, delta.z);
        }
    }

    public void liftScene(bool positiveMovement)
    {
        Vector3 delta = gameObject.transform.position;
        if (positiveMovement)
        {
            gameObject.transform.position = new Vector3(delta.x, delta.y+ movementScale, delta.z);
        }
        else 
        {
            gameObject.transform.position = new Vector3(delta.x, delta.y - movementScale, delta.z);
        }
    }
}
