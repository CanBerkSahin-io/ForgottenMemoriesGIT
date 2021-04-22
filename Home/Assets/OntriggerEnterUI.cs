using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OntriggerEnterUI : MonoBehaviour
{
    public GameObject uiObject;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    
    }
    public void OnTriggerEnter (Collider Player)    // collision with player
    {
        if (Player.gameObject.tag == "Player")
            {
                uiObject.SetActive(true);
                if (Input.GetMouseButtonDown(1))
                    {
                        Destroy(uiObject);
                    }
                StartCoroutine(WaitForSec());
               // Time.timeScale = 0;
                

}

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(9);
        uiObject.SetActive(false);
        Destroy(gameObject);
        Time.timeScale = 1;

    }
    }
}
