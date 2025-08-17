using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAlikeSwitcher : MonoBehaviour
{
    public GameObject renderObjectOne;
    public GameObject renderObjectTwo;
    public GameObject renderObjectThree;
    public GameObject renderObjectFour;
    public GameObject renderObjectFive;
    private int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        renderObjectTwo.SetActive(false);
        renderObjectThree.SetActive(false);
        renderObjectFour.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (count == 1)
        {
            renderObjectOne.SetActive(false);
            renderObjectTwo.SetActive(true);
        }
        else if (count == 2)
        {
            renderObjectTwo.SetActive(false);
            renderObjectThree.SetActive(true);
        }
        else if (count == 3)
        {
            renderObjectThree.SetActive(false);
            renderObjectFour.SetActive(true);
            gameObject.SetActive(false);
            
        }
    }

    public void increaseCount()
    {
        count++;
    }
}
