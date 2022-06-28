using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerEnterPlayer : MonoBehaviour
{
    public Animator cameraFade;
    
    public void OnTriggerEnter(Collider other)
    {
        cameraFade.Play("cameraAnimFade");
    }
}
