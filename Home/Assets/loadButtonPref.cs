using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadButtonPref : MonoBehaviour
{
    public GameObject uiPanel;
    private int currentSceneIndex;

    public void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }


    private void Load()
    {
        //load
        if (PlayerPrefs.HasKey("SavedScene"))
        {
            uiPanel.SetActive(true);
        }
        else
        {
            uiPanel.SetActive(false);
        }
    }



}
