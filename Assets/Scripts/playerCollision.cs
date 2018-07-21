using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {

	public playerMovement movement;
	public GameObject eMenu;

	void OnCollisionEnter (Collision colInfo){
		if (colInfo.collider.tag == "Obstacle") {
			movement.enabled = false;
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			//Application.Quit ();
			//eMenu.SetActive (true);
		}
		/*
		if (colInfo.collider.tag == "Target") {
			movement.enabled = false;
		}*/
	}
}
