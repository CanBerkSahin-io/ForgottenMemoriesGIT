using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Vector2 mouseLook;
    public Vector2 smoothV;
    public float smoothing = 2.0f;
 

    public GameObject player;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player = transform.parent.gameObject;
    }

    void Update()
    {
        Vector2 vct2 = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        smoothV.x = Mathf.Lerp(smoothV.x, vct2.x, 1 / smoothing); 
        smoothV.y = Mathf.Lerp(smoothV.y, vct2.y, 1 / smoothing); 
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -3f, 6f);
        mouseLook.x = Mathf.Clamp(mouseLook.x, -40f, 50f);
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
    }
}
