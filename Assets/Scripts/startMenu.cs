using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour {

	public void startGame() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
