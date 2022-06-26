using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColourDoor : MonoBehaviour
{
    [SerializeField]
    public Animator dooranimator;
    public AudioSource doorOpen;

    private string correctSequence, currentSequence;

    // Start is called before the first frame update
    void Start()
    {
        ButtonColor.SendColorValue += AddValueAndCheckSequence;
        correctSequence = "1234";
        currentSequence = "";

        doorOpen = GetComponent<AudioSource>();
    }

    private void AddValueAndCheckSequence(string colourButtons)
    {
        switch (colourButtons)
        {
            case "Blue":
                currentSequence += 1;
                break;
            case "Yellow":
                currentSequence += 2;
                break;
            case "Green":
                currentSequence += 3;
                break;
            case "Red":
                currentSequence += 4;
                break;

        }

        if (currentSequence != correctSequence.Substring(0, currentSequence.Length))
        {
            currentSequence = "";
        }
        else if (currentSequence == correctSequence)
        {
            dooranimator.Play("DoorAnim");
            currentSequence = "";
            //Destroy(gameObject);
            Debug.Log("Completed");
            doorOpen.Play();
        }
            
    }

    public void update()
    {
        Debug.Log(currentSequence);
    }
    
    

    private void OnDestroy()
    {
        ButtonColor.SendColorValue -= AddValueAndCheckSequence;
    }
}

