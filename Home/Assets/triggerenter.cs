using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerenter : MonoBehaviour

{
    public GameObject uitext;

    // Start is called before the first frame update
    void Start()
    {
        uitext.SetActive(false);
    
    }
    public void OnTriggerEnter (Collider Player)    // collision with player
    {
        if (Player.gameObject.tag == "Player")
            {
                uitext.SetActive(true);
            }
            else
            {
                uitext.SetActive(false);
            }
    }
    public void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "")
        {
            uitext.SetActive(false);
        }
    }
}