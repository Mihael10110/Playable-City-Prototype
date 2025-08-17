using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOnStart : MonoBehaviour
{

    public float xAngle;
    public float yAngle;
    public float zAngle;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Rotate(xAngle, yAngle, zAngle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
