using UnityEngine;

public class targetCollision : MonoBehaviour {

	public GameObject target;
	public playerMovement movement;

	public GameObject questionMenu;
	//public Qmenu qmenu;
	//public Qmenu qmenu;

	void OnCollisionEnter(Collision colInfo){
		if (colInfo.collider.tag == "Target") {
			movement.enabled = false;
			target.SetActive(false);
			questionMenu.SetActive (true);
			//movement.enabled = true;
		}
	}
}
