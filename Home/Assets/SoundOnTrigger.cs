using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnTrigger : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;
   
   void Start()
   {
       audioSource = GetComponent<AudioSource>();
   }

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "floor")
        {
            audioSource.PlayOneShot(impact, 0.5F);
        }
    }

}
