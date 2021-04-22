using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptFreeze : MonoBehaviour
{
    
    public AnimationClip anim = null;
    public GameObject MainCamera = null;

    public GameObject player = null;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        MainCamera.GetComponent<CamMouseLook>().enabled = false;
        player.GetComponent<CharacterControllerScript>().enabled = false;
        StartCoroutine(disableScript());
    }

        IEnumerator disableScript()
    {
        yield return new WaitForSeconds(35f);   
        SceneManager.LoadScene(3);

    }
    }

