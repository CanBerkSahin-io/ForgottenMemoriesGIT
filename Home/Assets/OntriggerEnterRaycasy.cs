using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerEnterRaycasy : MonoBehaviour

{

    public GameObject uitext;
    public GameObject ui;


    // Start is called before the first frame update
    void Start()
    {
        uitext.SetActive(false);
        ui.SetActive(false);
        
    
    }
    public void OnTriggerEnter (Collider Player)    // collision with player
    {
        if (Player.gameObject.tag == "Player")
            {
                ui.SetActive(false);
                uitext.SetActive(true);
                StartCoroutine("WaitForSec");

            }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(8);
        Destroy(uitext);
    }
}


