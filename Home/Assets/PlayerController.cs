using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [SerializeField] private Vector3 standHeight = new Vector3(0.23f, 4f, 0.1000001f);
    [SerializeField] private Vector3 crouchHeight = new Vector3(0.23f, 2f, 0.1000001f);

    private CharacterController _controller;
    public Transform fpsCam;

    private bool isCrouching;
    void Start()
    {
        

        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        Crouch();
    }

    void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale = crouchHeight;
            isCrouching = true;

        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            transform.localScale = standHeight;
            isCrouching = false;
        }
    }
}
