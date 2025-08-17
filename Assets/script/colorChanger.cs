using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ColorChanger : MonoBehaviour
{

    public Scrollbar scrollbar;
    public Material material;
    public Material orange;
    public Material brown;
    public Material purple;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(scrollbar.value == 0){
            material.color = Color.green;
            }
        else if(scrollbar.value <= 0.13){
            material.color = Color.blue;
            }
        else if(scrollbar.value <= 0.26){
            material.color = Color.yellow;
            }
        else if(scrollbar.value <= 0.38){
            material.color = Color.red;
            }
        else if(scrollbar.value <= 0.51){
            material.color = orange.color;
            }
        else if(scrollbar.value <= 0.63){
            material.color = brown.color;
            }
        else if(scrollbar.value <= 0.76){
            material.color = purple.color;
            }
        else if(scrollbar.value <= 0.88){
            material.color = Color.black;
            }
        else{
            material.color = Color.white;
        }
        
    }
}
