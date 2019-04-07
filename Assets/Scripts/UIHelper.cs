using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHelper: MonoBehaviour {

	// Use this for initialization
	public void ExitButton () {
		Application.Quit();
	}
	
	// Update is called once per frame
	public void RestartButton() {
		SceneManager.LoadScene("City");

	}
}
