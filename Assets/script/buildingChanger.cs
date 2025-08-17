using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class buildingChanger : MonoBehaviour
{
    public Scrollbar scrollbar;

    public GameObject mossyBuild;
    public GameObject brokenBuild;
    public GameObject freshBuild;

    public GameObject mossyBuildText;
    public GameObject brokenBuildText;
    public GameObject freshBuildText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(scrollbar.value <= 0.3){
            freshBuild.SetActive(true);
            brokenBuild.SetActive(false);
            mossyBuild.SetActive(false);
            }
        else if(scrollbar.value <= 0.6){
            freshBuild.SetActive(false);
            brokenBuild.SetActive(true);
            mossyBuild.SetActive(false);
            }
        else{
            freshBuild.SetActive(false);
            brokenBuild.SetActive(false);
            mossyBuild.SetActive(true);
        }
        
    }
}
