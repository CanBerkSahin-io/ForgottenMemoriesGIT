using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadYourAsyncScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        yield return new WaitForSeconds(35f);
        // Wait until the asynchronous scene fully loads
        
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("House Level 2");
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void loadscene()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }
}
