using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class drawable : MonoBehaviour
{
    public Texture2D texture;
    public int resolution = 1024;
    public Material drawingMaterial;

    public int brushThickness = 1;

    // Start is called before the first frame update
    void Start()
    {
        this.texture = new Texture2D(resolution, resolution);
        GetComponent<Renderer>().material.SetTexture("_BaseMap", this.texture);

    }

    public void drawOnTexture(int xChord, int yChord){
        for(int i = 0; i<brushThickness;i++){
            for(int j = 0; j<brushThickness;j++){
                if(i-(brushThickness/2)>=0){
                    if(j-(brushThickness/2)>=0){
                        this.texture.SetPixel(xChord, yChord, drawingMaterial.color);
                    }
                }
            }
        }
        this.texture.Apply();
    }
}
