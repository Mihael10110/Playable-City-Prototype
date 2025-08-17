using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    //These are the different Characters
    public GameObject myCharactersOne;
    public GameObject myCharactersTwo;
    public GameObject myCharactersThree;
    public GameObject myCharactersFour;
    public GameObject myCharactersFive;
    public GameObject myCharactersSix;

    //Here we store the List of Spawned Game Objects
    public List<GameObject> objectStore = new List<GameObject>();

    //Here we "store" the current selection state
    public int selectionState = 50;

    public void SpawnObject(GameObject gameObject)
    {
        RemoveAllObjects();
        GameObject currentObject = Instantiate(gameObject);
        objectStore.Add(currentObject);
    }

    public void StateChangePlus(){
        RemoveAllObjects();
        selectionState++;
        if((selectionState%6)==5){
            SpawnObject(myCharactersTwo);
        }
        else if((selectionState%6)==4){
            SpawnObject(myCharactersThree);
        }
        else if((selectionState%6)==3){
            SpawnObject(myCharactersFour);
        }
        else if((selectionState%6)==2){
            SpawnObject(myCharactersFive);
        }
        else if((selectionState%6)==1){
            SpawnObject(myCharactersSix);
        }
        else if((selectionState%6)==0)
        {
            SpawnObject(myCharactersOne);
        }        
    }

    public void StateChangeMinus(){
        RemoveAllObjects();
        selectionState--;
        int check = ((selectionState % 6) + 6) % 6;
        if ((check % 6) == 5)
        {
            SpawnObject(myCharactersTwo);
        }
        else if ((check % 6) == 4)
        {
            SpawnObject(myCharactersThree);
        }
        else if ((check % 6) == 3)
        {
            SpawnObject(myCharactersFour);
        }
        else if ((check % 6) == 2)
        {
            SpawnObject(myCharactersFive);
        }
        else if ((check % 6) == 1)
        {
            SpawnObject(myCharactersSix);
        }
        else if ((check % 6) == 0)
        {
            SpawnObject(myCharactersOne);
        }        
    }

    public void RemoveAllObjects(){
        foreach(GameObject odject in objectStore){
            Destroy(odject);
        }
    }

    void Start(){
        SpawnObject(myCharactersOne);
    }
}
