using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startScreen : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Space)){
			Invoke("LoadNextScene", 0.3f);
		}

	}

	void LoadNextScene() {
		SceneManager.LoadScene(1);
	}
}
