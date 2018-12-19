using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	public void playGame () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		
	}
	
	// Update is called once per frame
	public void quitGame() {
		Application.Quit ();
		Debug.Log ("Quit Game");

	}
}
