using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{

    public AudioSource voiceSFX;
    public AudioClip sfxClip;
    public float volume = 1f;
    private bool sfxPlayed = false;
    private bool hasCollide;

    public bool playOnce;
    // Start is called before the first frame update
    void Start()
    {
        playOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Player)
    {
        if(hasCollide == false && sfxPlayed == false)//   if the player has collided before then do not apply the code below, if not collided before, apply those.
            {
                if (Player.gameObject.tag == "Player")
                    {
                    hasCollide = true;//
                    voiceSFX.PlayOneShot(sfxClip, volume);
                    sfxPlayed = true;
                }
            }
            
    }
}
