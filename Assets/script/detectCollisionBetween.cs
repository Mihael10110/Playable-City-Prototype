using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class detectCollisionBetween : MonoBehaviour
{

    
    public GameObject animationObject;
    public AudioSource source;
    public AudioClip clip;
    private bool hasBeenPranked = false;
    private bool contactStart = false;
    private bool contactEnd = false;
    private GameObject[] childrenOfObject;
    private List<GameObject> objectStore;

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "passageOne"){
            other.gameObject.GetComponent<Renderer>().enabled = false;
        }
        if ((other.gameObject.tag == "pressButton") && (!hasBeenPranked)){
            other.gameObject.transform.position = other.gameObject.transform.position - new Vector3(0.0f,0.02f,0.0f);
            source.PlayOneShot(clip);
            hasBeenPranked = true;
        }
        if (other.gameObject.tag == "appearObject"){
            showAllChildren(other.gameObject);
            contactStart = true;
        }
    }

    void Start() {
        objectStore = new List<GameObject>();
    }

    void Update(){
        if(contactStart){
            SpawnObject(animationObject);
            contactStart = false;
        }
        else if(contactEnd){
            RemoveAllObjects();
            contactEnd = false;
        }
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "passageOne"){
            other.gameObject.GetComponent<Renderer>().enabled = true;
        }
        if ((other.gameObject.tag == "pressButton") && (!hasBeenPranked)){
            other.gameObject.transform.position = other.gameObject.transform.position + new Vector3(0.0f,0.04f,0.0f); 
        }
        if (other.gameObject.tag == "appearObject"){
            hideAllChildren(other.gameObject);
            contactEnd = true;
        }
    
    }

    private void hideAllChildren(GameObject game){
        childrenOfObject = new GameObject[game.transform.childCount];

        for(int i = 0; i< game.transform.childCount;i++){
            game.transform.GetChild(i).gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    private void showAllChildren(GameObject game){
        childrenOfObject = new GameObject[game.transform.childCount];

        for(int i = 0; i< game.transform.childCount;i++){
            game.transform.GetChild(i).gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
    private void SpawnObject(GameObject gameObject){
        GameObject currenttObject = Instantiate(gameObject);
        objectStore.Add(currenttObject);
    }

    private void RemoveAllObjects(){
        foreach(GameObject odject in objectStore){
            Destroy(odject);
        }
    }

}
