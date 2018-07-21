
using UnityEngine;

public class correctAnswer : MonoBehaviour {

	public playerMovement mvement;
	public GameObject menuu;

	public void Resume(){
		menuu.SetActive (false);
		mvement.enabled = true;

	}
}
