using UnityEngine;
using System.Collections;

public class BasicDoorController : MonoBehaviour
{
    private Animator doorAnim;
    private bool doorOpen = false;
    public AudioSource openAudioSource;
    public AudioSource closeAudioSource;

    [Header("Animation Names")]
    [SerializeField] private string openAnimationName = "DoorOpen";
    [SerializeField] private string closeAnimationName = "DoorClose";


    [Header("Pause Timer")]
    [SerializeField] private int waitTimer = 1;
    [SerializeField] private bool pauseInteraction = false;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
        
    }

    private IEnumerator PauseDoorInteraction()
    {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer);
        pauseInteraction = false;

    }

    public void PlayAnimation()
    {
        if (!doorOpen && !pauseInteraction)
        {
            doorAnim.Play(openAnimationName, 0, 0.0f);
            openAudioSource.Play();
            doorOpen = true;
            StartCoroutine(PauseDoorInteraction());
        }

        else if(doorOpen && !pauseInteraction)
        {
            doorAnim.Play(closeAnimationName, 0, 0.0f);
            closeAudioSource.Play();
            doorOpen = false;
            StartCoroutine(PauseDoorInteraction());
        }
    }
}
