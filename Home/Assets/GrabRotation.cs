using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 50f;


    public void FixedUpdate()
    {
        {
            float h = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

            GetComponent<Rigidbody>().AddTorque(transform.up * h);
        }
    }




}
