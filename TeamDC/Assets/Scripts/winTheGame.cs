using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winTheGame : MonoBehaviour {

	public Text winText;
	bool p1In;
	public int loadThis; //assign in inspector
	//bool p2In;

	void Start(){

		winText = GameObject.Find("winText").GetComponent<Text>();
		p1In = false;
		//p2In = false;

	}

	void OnTriggerEnter (Collider activator){

		//Debug.Log("The one inside is " + activator.name);

		if(activator.name == "MainP") {
			//winText.text = "Congrats You Won!";
			StartCoroutine(LoadNextLevel());
		}


	}
		
	IEnumerator LoadNextLevel(){
		float fadeTime = GameObject.Find("FadeManager").GetComponent<FadingScript>().StartFade(1);
		Debug.Log(fadeTime);
		yield return new WaitForSeconds(fadeTime);

		if(loadThis == 0){
			Destroy(GameObject.Find("SoundManager"));
		}
		SceneManager.LoadScene(loadThis);
	}


}
