using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingToObject : MonoBehaviour
{
    public static string selectedObject;
    public string internalObject;
    public RaycastHit theObject;

    public GameObject[] target;

    public Animator painting1;
    public Animator painting2;
    public Animator cabindoor;

    
    public AudioSource voiceSFX;
    public AudioClip sfxClip;
    public float volume = 1f;

    public bool playSFXonce;
    public static float DistanceFromTarget;

    public float toTarget;

    public bool painting1played;
    public bool painting2played;

    public void Start()
    {
        painting1played = false;
        painting2played = false;
        playSFXonce = false;
    }
    // Update is called once per frame
    void Update()
    { 
        RaycastHit Hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out Hit))
        {
            if(Hit.collider.tag == "Painting1")
            {
                if(Input.GetMouseButtonDown(0))
                {
                    painting1played = true;
                    target = GameObject.FindGameObjectsWithTag("Painting1");
                    painting1.Play("paint");
    
                }
            
            }
            toTarget = Hit.distance;
            DistanceFromTarget = toTarget; 
              
             if(Hit.collider.tag == "Painting")
            {
                if(Input.GetMouseButtonDown(0))
                {
                    painting2played = true;
                    target = GameObject.FindGameObjectsWithTag("Painting");
                    painting2.Play("painting");
                    
                }
            
            }

        }

        if(painting1played == true && painting2played == true && playSFXonce== false)
        {
            playSFXonce = true;
            cabindoor.Play("cabindooranim");
            voiceSFX.PlayOneShot(sfxClip, volume);
        }
    }


}
