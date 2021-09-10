using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUIIntro : MonoBehaviour
{
    public GameObject background;
    public GameObject firstText;
    public GameObject secondText;
    public GameObject thirdText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Update");
    }

    // Update is called once per frame
    IEnumerator Update()
    {
        yield return new WaitForSeconds(6F);
        firstText.SetActive(true);
        background.SetActive(true);
        yield return new WaitForSeconds(5F);
        firstText.SetActive(false);
        background.SetActive(false);
        yield return new WaitForSeconds(5F);
        secondText.SetActive(true);
        background.SetActive(true);
        yield return new WaitForSeconds(5F);
        secondText.SetActive(false);
        background.SetActive(false);
        yield return new WaitForSeconds(0.8F);
        thirdText.SetActive(true);
        background.SetActive(true);

    }

}
