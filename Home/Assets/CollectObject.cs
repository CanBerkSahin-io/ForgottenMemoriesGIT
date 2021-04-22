using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public AudioSource collectSound;

    public GameObject UI;
    public GameObject uiImage;
     private bool hasCollide = false;

     void start()
     {
        UI.SetActive(false);
        uiImage.SetActive(false);
     }
    void OnTriggerEnter(Collider Player)
    {
        if(hasCollide == false)//   if the player has collided before then do not apply the code below, if not collided before, apply those.
            {
                if (Player.gameObject.tag == "Player")
                    {
                    hasCollide = true;//
                    uiImage.SetActive(true);
                    UI.SetActive(true);
                    collectSound.Play();
                    Scoring.theScore += 1;
                    StartCoroutine(WaitForSec());

            }
            
    }

        IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(9);
        UI.SetActive(false);
        uiImage.SetActive(false);

    }

   

}
}
