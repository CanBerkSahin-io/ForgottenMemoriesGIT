using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerEnter1 : MonoBehaviour
{
    public GameObject uiObject;
    public AudioSource driving;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }
    public void OnTriggerEnter (Collider player)    // collision with player
    {
        if (player.gameObject.tag == "Player")
            {
                driving.Stop();
                uiObject.SetActive(true);
                

                StartCoroutine(WaitForSec());
    // Update is called once per frame

}

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(8.5F);
        AsyncOperation operation = SceneManager.LoadSceneAsync(2);

        while (!operation.isDone)
        {
            Debug.Log(operation.progress);

            yield return null; 
        }
        //SceneManager.LoadScene(2);
        

    }
    }
}
