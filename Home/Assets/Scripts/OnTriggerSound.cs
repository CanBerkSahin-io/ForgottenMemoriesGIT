using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerSound : MonoBehaviour
{

    public AudioSource crashSound;
    public AudioSource CarHornSound;

    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter (Collider player)    // collision with player
    {
        if (player.gameObject.tag == "Player")
            {
                crashSound.Play();  
                CarHornSound.Play();
    // Update is called once per frame

}
    }
}

    

