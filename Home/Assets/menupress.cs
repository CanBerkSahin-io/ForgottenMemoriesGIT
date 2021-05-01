using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menupress : MonoBehaviour
{

    public GameObject SelfUI;
    public GameObject MenuButtonsUI;
    public GameObject MenuButtonsCanvas;
    public AudioSource menuMP3;


    public void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    public void OnKeyEnter()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            menuMP3.Play(0);
            SelfUI.SetActive(false);
            MenuButtonsUI.SetActive(true);
            MenuButtonsCanvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }


}
