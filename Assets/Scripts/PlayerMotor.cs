 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

	private CharacterController controller;
	private Vector3 moveVector;

	private float speed = 4.0f;
	private float verticalVelocity = 0.0f;
	private float gravity = 12.0f;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();	
	}
	
	// Update is called once per frame
	void Update () {
		moveVector = Vector3.zero;

		if (controller.isGrounded) {
			verticalVelocity = -0.5f;
		} 
		else {
			verticalVelocity -= gravity * Time.deltaTime;
		}

		//X - lft & right
		moveVector.x = Input.GetAxis("Horizontal") * speed;

		//Y - up & dwn
		moveVector.y = verticalVelocity;

		//Z - forwrd & backwrd
		moveVector.z = speed;

		controller.Move (moveVector * Time.deltaTime);
	}
}
