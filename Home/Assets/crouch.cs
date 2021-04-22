using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{
    public Camera MainCamera;
    private Vector3 CrouchView = new Vector3(0.01999968f,0.09f,0.03000009f);
    private Vector3 NormalView = new Vector3(0.01999968f,0.546f,0.03000009f);
    

    

    void Start () 
 {
  
    MainCamera = Camera.main; // Grab a reference to the camera
 }
    
    
    
    void update () 
 {
    if (Input.GetButton("Fire1"))
    {
        MainCamera.transform.position = CrouchView;
        
    }
    else
    {
        MainCamera.transform.position = NormalView;
    }
 }
    


}
