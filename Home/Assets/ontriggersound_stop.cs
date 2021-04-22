using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ontriggersound_stop : MonoBehaviour
{

    public AudioSource IntroMusic;
    public AudioSource SecondMusic;
    public GameObject trigger;

    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter (Collider player)    // collision with player
    {
        if (player.gameObject.tag == "Player")
            {
                SecondMusic.Play();  
                IntroMusic.Stop();
                Destroy(trigger);
}
    }
}

    

