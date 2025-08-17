using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterChanger : MonoBehaviour
{
   //These are the different Celebrities/People
    public GameObject renderObjectOne;
    public GameObject renderObjectTwo;
    public GameObject renderObjectThree;
    public GameObject renderObjectFour;
    public int state = 0;

    void Update(){
        if((state%4)==0){
            renderObjectOne.SetActive(true);
        }
        else if((state%4)==1){
            renderObjectOne.SetActive(false);
            renderObjectTwo.SetActive(true);
        }
        else if((state%4)==2){
            renderObjectTwo.SetActive(false);
            renderObjectThree.SetActive(true);
        }
        else if((state%4)==3){
            renderObjectThree.SetActive(false);
            renderObjectFour.SetActive(true);
        }
    }

    public void increaseState(){
        state+=1;
    }
}
