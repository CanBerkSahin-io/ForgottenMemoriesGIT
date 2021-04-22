// ToggleLight.cs
// Turns the light component of this object on/off when the user presses and releases the `F` key.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour {

	public Light Flashlight;

    public bool on = true;

	// Use this for initialization
	void Start () {
        on = true;
		
	}

	// Update is called once per frame
	void Update () {
		// Toggle light on/off when L key is pressed.
		if (Input.GetKeyDown (KeyCode.F)) {
            if(on == true)
            {
                Flashlight.enabled = false;
                on =false; 
            }
            else {
                Flashlight.enabled = true;
                on = true;
            }
		}
	}
}
