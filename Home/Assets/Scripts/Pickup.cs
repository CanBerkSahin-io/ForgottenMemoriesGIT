using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform theDest;
   public float TheDistance;

   void update()
   {
       TheDistance = CastingToObject.DistanceFromTarget;
   }

   void OnMouseDown()
   {
       if (TheDistance <= 7) {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("thedest").transform;
       }
   }
   
   void OnMouseUp()
   {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
   }
}
