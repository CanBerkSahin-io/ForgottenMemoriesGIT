using UnityEngine;
using System.Collections;
 
/// <summary>
/// Creates wandering behaviour for a CharacterController.
/// </summary>
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
public class wander : MonoBehaviour
{
	public float speed = 3;
	public float directionChangeInterval = 20f;
	public float maxHeadingChange = 10;

    Animator animator;
 
	CharacterController controller;
	float heading;
	Vector3 targetRotation;
 
	void Awake ()
	{
		controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
 
		// Set random initial rotation
		heading = Random.Range(0, 0);
		transform.eulerAngles = new Vector3(0, heading, 0);
 
		StartCoroutine(NewHeading());
	}
 
	void Update ()
	{
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
		var forward = transform.TransformDirection(Vector3.forward);
		controller.SimpleMove(forward * speed);
        animator.Play("walk");

        if(speed == 3)
        {
            animator.Play("walk");
        }
        else
        {
            animator.Play("idle");
        }
	}
 
	/// <summary>
	/// Repeatedly calculates a new direction to move towards.
	/// Use this instead of MonoBehaviour.InvokeRepeating so that the interval can be changed at runtime.
	/// </summary>
	IEnumerator NewHeading ()
	{
		while (true) {
			NewHeadingRoutine();
            transform.eulerAngles = new Vector3(0, 0, 0);
			yield return new WaitForSeconds(directionChangeInterval);
            transform.eulerAngles = new Vector3(0, heading, 0);
            
		}
	}
 
	/// <summary>
	/// Calculates a new direction to move towards.
	/// </summary>
	void NewHeadingRoutine ()
	{
		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 0);
		var ceil  = Mathf.Clamp(heading + maxHeadingChange, 0, 0);
		heading = Random.Range(floor, ceil);
		targetRotation = new Vector3(0, heading, 0);
	}
}