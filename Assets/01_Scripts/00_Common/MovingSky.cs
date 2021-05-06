using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSky : MonoBehaviour
{

    public float ScrollSpeed = 1.0f;
    float Offset;
    Renderer renderer;
     
     void Start(){
         renderer=GetComponent<Renderer>();
     }
    void Update ()
    {      
        Offset += Time.deltaTime * ScrollSpeed;
        renderer.material.mainTextureOffset = new Vector2 (Offset, 0);     
    }

}
