using System.Collections;
using UnityStandardAssets.Utility;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{

    //public Interactable focus;
    // Start is called before the first frame update
    public float speed = 10.0F;

    public float run = 10.0f;
    public Rigidbody rb;
    public AudioSource audioSrc;
    public bool playerGrounded = true;
    public bool isMoving;
    void Start()
    {
        Time.timeScale = 1f;
        Cursor.lockState= CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        bool isMoving = true;
        transform.Translate(straffe, 0, translation);

        //jump command
        
        if (Input.GetButtonDown("Jump") && playerGrounded){
            rb.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
            playerGrounded = false;

        }
        

        if (isMoving == true)
            audioSrc.Play();
            
       
        if (Input.GetKeyDown("escape"))
            Cursor.lockState= CursorLockMode.None;   // if escape key is pressed, the cursor will be unlocked
            //if right mouse button is pressed
        if (Input.GetMouseButtonDown(1))
        {
            //creating a ray

            //if the ray hits
        
            {
                //check if we hit an interactablel)
                {
                    //add command to include text box and sound effect
                    
                }
            }
        }
    }
       private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Ground")
        {
            playerGrounded = true;
        }
    }
}


