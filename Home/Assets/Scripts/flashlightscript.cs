// ToggleLight.cs
// Turns the light component of this object on/off when the user presses and releases the `F` key.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightscript : MonoBehaviour {
    
    public bool isOn = false;
	public GameObject lightSource;
    public AudioSource clickSound;
    public bool failSafe =  false;    

	// Update is called once per frame
	void Update () {
		// Toggle light on/off when L key is pressed.
		if (Input.GetButtonDown ("FKey")) {
            if(isOn == false && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(true);
                clickSound.Play();
                isOn =true; 
                StartCoroutine(FailSafe());
            }
            if (isOn == true && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(false);
                clickSound.Play();
                isOn = false;
                StartCoroutine(FailSafe());
            }
            
		}
	}
    IEnumerator FailSafe()
    {
        yield return new WaitForSeconds(0.25f);
        failSafe = false;
    }
}

