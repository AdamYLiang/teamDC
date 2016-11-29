using UnityEngine;
using System.Collections;

public class LightFade : MonoBehaviour {
	public float highIntensity;
    public float lowIntensity;
    public float fadeSpeed;
    public float fadeInCap;
	public float fadeOutCap;
	bool fadingOut;
	bool fadingIn;


	// Use this for initialization
	void Start () {

		fadeInCap = 4.90f;
		fadeOutCap = 0.10f;
		highIntensity = 5.0f;
		lowIntensity = 0.0f;
		fadeSpeed = 3;
		fadingOut = false;
		fadingIn = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if ((gameObject.GetComponent<Light>().intensity > fadeInCap) || fadingOut)
        {
			//Debug.Log("fade out please " + gameObject.GetComponent<Light>().intensity);
			fadingOut = true;
			fadingIn = false;
            gameObject.GetComponent<Light>().intensity = Mathf.Lerp(gameObject.GetComponent<Light>().intensity, lowIntensity, fadeSpeed * Time.deltaTime);
		}

		if ((gameObject.GetComponent<Light>().intensity < fadeOutCap) || fadingIn)
        {
			fadingIn = true;
			fadingOut = false;
			//Debug.Log("fade in please " + gameObject.GetComponent<Light>().intensity);
            gameObject.GetComponent<Light>().intensity = Mathf.Lerp(gameObject.GetComponent<Light>().intensity, highIntensity, fadeSpeed * Time.deltaTime);
		}
	}}
