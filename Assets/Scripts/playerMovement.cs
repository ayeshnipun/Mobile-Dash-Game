using UnityEngine;
/*
public class playerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sideForce = 500f;

	private Vector3 moveVector;

	void FixedUpdate () 
	{
		rb.AddForce(0,0,forwardForce*Time.deltaTime);

		if (Input.GetKey("d")){
			rb.AddForce (sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a")){
			rb.AddForce (-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
		}
	}
}


*/
public class playerMovement : MonoBehaviour {

	private CharacterController controller;
	private Vector3 moveVector;

	private float speed = 15.0f;
	private float verticalVelocity = 0.0f;
	private float gravity = 12.0f;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();	
	}
	
	// Update is called once per frame
	void Update () {
		speed = speed + 0.05f;
		moveVector = Vector3.zero;
 
		//X - lft & right
		moveVector.x = Input.GetAxis("Horizontal") * speed;
		if (Input.GetMouseButton(0)){
			//r v holding touch on right side
			if (Input.mousePosition.x > Screen.width / 2) {
				moveVector.x = speed/2;
			} 
			else {
				moveVector.x = -speed/2;
			}
		}

		//Y - up & dwn
		moveVector.y = verticalVelocity;

		//Z - forwrd & backwrd
		moveVector.z = speed;

		controller.Move (moveVector * Time.deltaTime);
	}
}
/*
public class playerMovement : MonoBehaviour 
{
	private CharacterController controller;
	private float speed = 5.0f;

	void Start (){
		controller = GetComponent<CharacterController> ();
	}

	void Update (){
		controller.Move ((Vector3.forward * speed) * Time.deltaTime);
	}
}*/