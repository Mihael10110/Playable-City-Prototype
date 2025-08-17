using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger1 : MonoBehaviour
{
    public Material orange;
    public Material purple;
    private int count = 20;
    void Update()
    {
        count++;
        if (count > 30)
        {
            randomColorChange();
            count = 0;
        }
    }

    public void randomColorChange()
    {
        int choice = Random.Range(0, 6);
        colorChange(choice);

    }

    public void colorChange(int choice)
    {
        var objectMaterial = gameObject.GetComponent<Renderer>();
        if (choice == 0)
        {
            objectMaterial.material.color = Color.green;
        }
        else if (choice == 1)
        {
            objectMaterial.material.color = Color.blue;
        }
        else if (choice == 2)
        {
            objectMaterial.material.color = Color.yellow;
        }
        else if (choice == 3)
        {
            objectMaterial.material.color = Color.red;
        }
        else if (choice == 4)
        {
            objectMaterial.material.color = orange.color;
        }
        else
        {
            objectMaterial.material.color = purple.color;
        }
        
    }
}
