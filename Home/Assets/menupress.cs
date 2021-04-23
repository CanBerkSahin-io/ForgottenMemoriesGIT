using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menupress : MonoBehaviour
{

    public GameObject SelfUI;
    public GameObject MenuButtonsUI;
    public GameObject SubmitUI;

    public void OnKeyEnter()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SelfUI.SetActive(false);
            MenuButtonsUI.SetActive(true);
            SubmitUI.SetActive(true);
        }
    }


}
