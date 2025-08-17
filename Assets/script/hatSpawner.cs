using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatSpawner : MonoBehaviour
{
   //These are the different Hats
    public GameObject myHatsOne;
    public GameObject myHatsTwo;
    public GameObject myHatsThree;
    public GameObject myHatsFour;
    public GameObject parent;

    //Here we store the List of Spawned Game Objects
    public List<GameObject> objectStore = new List<GameObject>();

    //Here we "store" the current selection state
    public int selectionState = 50;

    public void SpawnObject(GameObject gameSelectObject){
        RemoveAllObjects(); 
        GameObject currentObject = Instantiate(gameSelectObject, parent.transform, true);
        objectStore.Add(currentObject);
    }

    public void StateChangePlus(){
        RemoveAllObjects();
        selectionState++;
        if((selectionState%4)==3){
            SpawnObject(myHatsTwo);
        }
        else if((selectionState%4)==2){
            SpawnObject(myHatsThree);
        }
        else if((selectionState%4)==1){
            SpawnObject(myHatsFour);
        }
        else if((selectionState%4)==0)
        {
            SpawnObject(myHatsOne);
        }        
    }

    public void StateChangeMinus(){
        RemoveAllObjects();
        selectionState--;
        if((selectionState%4)==3){
            SpawnObject(myHatsTwo);
        }
        else if((selectionState%4)==2){
            SpawnObject(myHatsThree);
        }
        else if((selectionState%4)==1){
            SpawnObject(myHatsFour);
        }
        else if((selectionState%4)==0)
        {
            SpawnObject(myHatsOne);
        }        
    }

    public void RemoveAllObjects(){
        foreach(GameObject odject in objectStore){
            Destroy(odject);
        }
    }

    void Start(){
        SpawnObject(myHatsOne);
    }
}
