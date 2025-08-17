using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class preferenceSPawner : MonoBehaviour
{
    //These are the different Objects
    public GameObject myObjectsOne;
    public GameObject myObjectsTwo;
    public GameObject myObjectsThree;

    //These are the different Buttons
    public Button myButtonsOne;
    public Button myButtonsTwo;
    public Button myButtonsThree;

    //Here we store the List of Spawned Game Objects
    public List<GameObject> objectStore;

    //Here we "store" the current selection state
    public int selectionState = 0;

    public void SpawnObject(GameObject gameObject){
        RemoveAllObjects();
        GameObject currentObject = Instantiate(gameObject);
        objectStore.Add(currentObject);
    }

    public void StateChangeUpdate(){
        RemoveAllObjects();
        if((selectionState%3)==2){
            SpawnObject(myObjectsThree);
            visualDeselect(myButtonsOne);
            visualDeselect(myButtonsTwo);
        }
        else if((selectionState%3)==1){
            SpawnObject(myObjectsTwo);
            visualDeselect(myButtonsOne);
            visualDeselect(myButtonsThree);
        }
        else if((selectionState%3)==0)
        {
            SpawnObject(myObjectsOne);
            visualDeselect(myButtonsThree);
            visualDeselect(myButtonsTwo);
        }        
    }

    public void RemoveAllObjects(){
        foreach(GameObject odject in objectStore){
            Destroy(odject);
        }
    }

    public void visualDeselect(Button button){
        button.OnPointerExit(null);
    }

    public void stateOne(){
        selectionState = 0;
        StateChangeUpdate();
    }
    public void stateTwo(){
        selectionState = 1;
        StateChangeUpdate();
    }
    public void stateThree(){
        selectionState = 2;
        StateChangeUpdate();
    }

    void Start(){
        SpawnObject(myObjectsOne);
    }
}
