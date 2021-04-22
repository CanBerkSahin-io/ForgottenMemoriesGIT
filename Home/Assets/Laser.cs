using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class Laser : MonoBehaviour 
{
    public int reflections;
    public float maxLength;

    public AudioSource sfx;

    public Animator doorOpenAnim;

    private LineRenderer lineRenderer;
    private Ray ray;
    private RaycastHit hit;
    private Vector3 direction;

    private Vector3 lastHitPosition;//

    public bool door;
    public bool previousHit;





    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        Vector3 lastHitPosition = transform.position;

        previousHit = false;
    }

    public void Update()
    {

        ray = new Ray(transform.position, transform.forward);  

        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0,transform.position);
        float remainingLength = maxLength;

        for (int i = 0; i < reflections; i++)
        {
            if(Physics.Raycast(ray.origin,ray.direction, out hit, remainingLength))
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, hit.point);
                remainingLength -= Vector3.Distance(ray.origin, hit.point);
                lastHitPosition = hit.point;//
                ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
                sfx.Play();
                if(hit.collider.tag != "Mirror")
                {
                    break;
                }
            }
            else
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, ray.origin + ray.direction * remainingLength);
            }

        }
    }
    public void FixedUpdate()
    {

        
        
        
        Vector3 lastHitPosition = transform.position;
        ray = new Ray(hit.point, Vector3.Reflect(transform.forward, hit.normal));

        if(Physics.Raycast(ray.direction, transform.position))   //raycast checks if cavedoor is hit, if so open the door.
            {
               
                if(hit.collider.tag == "CaveDoor")
                    {
                        Debug.Log(hit.transform.name);
                        Debug.DrawLine(transform.position, hit.point, Color.green);
                        doorOpenAnim.Play("testdooranim");
                        Debug.Log("raycast hitting cavedoor");
                        door = true;
                        previousHit = true;
                    }
                else
                {
                    if(this.doorOpenAnim.GetCurrentAnimatorStateInfo(1).IsName("testdooranim"))
                    {
                        doorOpenAnim.Play("closedoortest");                    
                    }
                }
            }
        

            
            
    }





}