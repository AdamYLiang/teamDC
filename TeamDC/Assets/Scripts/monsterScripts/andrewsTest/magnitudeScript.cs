using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class magnitudeScript : MonoBehaviour {

    [SerializeField]
    Transform player1;

    [SerializeField]
    Transform player2;

    public float mag;
    public Text text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        mag = (player2.position - player1.position).magnitude;
        text.text = mag.ToString();


	}
}
