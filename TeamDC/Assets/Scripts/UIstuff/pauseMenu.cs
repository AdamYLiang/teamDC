using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

	public Image pauseUI;
	public Button cont;
	public Button retry;
	public Button mainM;
	public int currentScene;
	public Text levelText;

	//To put into inspector, make sure UIManager is there and hooked up correctly
	//Also use the onclick settings 

	public void Start(){

		levelText = GameObject.Find("levelText").GetComponent<Text>(); 
		currentScene = SceneManager.GetActiveScene().buildIndex;
		//pauseUI = GameObject.Find("pausePanel");
		pauseUI.enabled = false;
		disableButtons();
		levelText.text = "Level " + SceneManager.GetActiveScene().buildIndex;
		//pauseUI.SetActive(false);

	}

	public void Update(){

		if(Input.GetKeyDown(KeyCode.Escape)){
			togglePause();
		}

		if(Input.GetKeyDown(KeyCode.R)){
			reload();
		}

	}

	public void togglePause(){
		if(pauseUI.enabled){
			disableButtons();
			Time.timeScale = 1.0f;
			pauseUI.enabled = false;
		}
		else{
			enableButtons();
			Time.timeScale = 0f;
			pauseUI.enabled = true;
		}
	}

	public void enableButtons(){
		cont.gameObject.SetActive(true);
		retry.gameObject.SetActive(true);
		mainM.gameObject.SetActive(true);
	}

	public void disableButtons(){
		cont.gameObject.SetActive(false);
		retry.gameObject.SetActive(false);
		mainM.gameObject.SetActive(false);
	}

	public void reload(){
		Time.timeScale = 1f;
		SceneManager.LoadScene(currentScene);
	}

	public void gotoMM(){
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}

}
