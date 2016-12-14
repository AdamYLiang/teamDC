using UnityEngine;
using System.Collections;

public class DoorSoundCrashScript : MonoBehaviour {

	public AudioSource doorHit;

	public void playDoorCrash(){
		doorHit.Play();
	}
}
