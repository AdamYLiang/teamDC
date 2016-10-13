using UnityEngine;
using System.Collections;

public class LightFade : MonoBehaviour {
    public float highIntensity = 1.0f;
    public float lowIntensity = 0.0f;
    public float fadeSpeed = 0.1f;
    public float fadeInCap = 0.99f;
    public float fadeOutCap = 0.01f;
    bool fadeIn;
    bool fadeOut;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(gameObject.GetComponent<Light>().intensity > fadeInCap)
        { fadeOut = true;
            fadeIn = false;
        }
        if (gameObject.GetComponent<Light>().intensity < fadeOutCap)
        {
            fadeOut = false;
            fadeIn = true;
        }

        if (fadeIn == true)
        {
            if (gameObject.GetComponent<Light>().intensity < highIntensity)
                gameObject.GetComponent<Light>().intensity = Mathf.Lerp(gameObject.GetComponent<Light>().intensity, highIntensity, fadeSpeed * Time.deltaTime);
        }
       if (fadeOut == true)
        {
            if (gameObject.GetComponent<Light>().intensity < highIntensity)
                gameObject.GetComponent<Light>().intensity = Mathf.Lerp(gameObject.GetComponent<Light>().intensity, lowIntensity, fadeSpeed * Time.deltaTime);
        }

    }
}
