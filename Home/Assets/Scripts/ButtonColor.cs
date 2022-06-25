using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ButtonColor : MonoBehaviour
{
    public static event Action<string> SendColorValue = delegate { };

    public void ButtonClicked()
    {
        SendColorValue(name.Substring(0, name.IndexOf("_")));
    }

}


