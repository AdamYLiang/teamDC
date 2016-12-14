using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadingScript : MonoBehaviour {

	public Texture2D fadeTexture;
	public float fadeSpeed = 0.8f;
	private int drawdepth = -1000;
	private float alpha = 1.0f;
	private int fadeDirection = -1;

	void Awake(){
		StartFade(-1);
	}

	void OnGUI(){

		alpha += fadeDirection * fadeSpeed * (float)Time.deltaTime;
		alpha = Mathf.Clamp01(alpha);

		GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawdepth;
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTexture);
}

	//fade in is -1 and fade out is 1
	public float StartFade(int direction){
		fadeDirection = direction;
		return(fadeSpeed);
	}
		

}
