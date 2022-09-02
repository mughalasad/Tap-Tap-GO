using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float speed;
    public Renderer background; 
    void Update()
    {
        background.material.mainTextureOffset += new Vector2(speed*Time.deltaTime,0f);
        
    }
}
