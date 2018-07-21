using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endMenu : MonoBehaviour {
	public void Quit() {
		Application.Quit ();
	}

	public void res() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex-1);
	}
}
