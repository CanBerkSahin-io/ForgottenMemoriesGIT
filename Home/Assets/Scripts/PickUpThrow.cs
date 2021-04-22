using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpThrow : MonoBehaviour
{
	public Transform ObjectHolder;
	public float ThrowForce;
	public GameObject UI;
	public GameObject uitext;
	public bool carryObject;
	public GameObject Item;
	public bool IsThrowable;
	public GameObject Item2;
	// Start is called before the first frame update
	void Start()
	{
		UI.SetActive(false);
		uitext.SetActive(false);

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			RaycastHit hit;
			Ray directionRay = new Ray(transform.position, transform.forward);
			if (Physics.Raycast(directionRay, out hit, 4f))
			{
					//UI.SetActive(true);
				if (hit.collider.tag == "Object")
				{
					carryObject = true;
					IsThrowable = true;
					if (carryObject == true)
					{
						
						UI.SetActive(true);
						//uitext.SetActive(false);
						Item = hit.collider.gameObject;
						Item.transform.SetParent(ObjectHolder);
						Item.gameObject.transform.position = ObjectHolder.position;
						Item.GetComponent<Rigidbody>().isKinematic = true;
						Item.GetComponent<Rigidbody>().useGravity = false;
						//For item 2

						Item2 = hit.collider.gameObject;
						Item2.transform.SetParent(ObjectHolder);
						Item2.gameObject.transform.position = ObjectHolder.position;
						Item2.GetComponent<Rigidbody>().isKinematic = true;
						Item2.GetComponent<Rigidbody>().useGravity = false;
						
					}
				}
			}
		}
		if (Input.GetMouseButton(1))
		{
			carryObject = false;
			IsThrowable = false;
		}
		if (carryObject == false)
		{
			ObjectHolder.DetachChildren();
			Item.GetComponent<Rigidbody>().isKinematic = false;
			Item.GetComponent<Rigidbody>().useGravity = true;
			//for item 2
			Item2.GetComponent<Rigidbody>().isKinematic = false;
			Item2.GetComponent<Rigidbody>().useGravity = true;
			UI.SetActive(false);
		}
		if (Input.GetMouseButton(0))
		{
			if (IsThrowable)
			{
				ObjectHolder.DetachChildren();
				Item.GetComponent<Rigidbody>().isKinematic = false;
				Item.GetComponent<Rigidbody>().useGravity = true;
				Item.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * ThrowForce);
				//for item 2
				Item2.GetComponent<Rigidbody>().isKinematic = false;
				Item2.GetComponent<Rigidbody>().useGravity = true;
				Item2.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * ThrowForce);
				UI.SetActive(false);
			}
		}
	}

}