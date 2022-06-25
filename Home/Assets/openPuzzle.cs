using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPuzzle : MonoBehaviour
{

    public GameObject puzzleCanvas;

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController fpc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Action for clicking keypad( GameObject ) on screen
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                var selection = hit.transform;

                if (selection.CompareTag("PuzzleUI")) // Tag on the gameobject - Note the gameobject also needs a box collider
                {
                    puzzleCanvas.SetActive(true);

                }
            }
        }

        if((puzzleCanvas.activeInHierarchy == true) && Input.GetKeyDown(KeyCode.Escape))
        {
            puzzleCanvas.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            fpc.enabled = true;
            
        }

        if(puzzleCanvas.activeInHierarchy == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            fpc.enabled = false;
        }
    }
}
