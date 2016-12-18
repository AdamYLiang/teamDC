using UnityEngine;
using System.Collections;

public class DoorSoundCrashScript : MonoBehaviour {

	public AudioSource doorHit;
	public AudioSource enemyHit;

	public void playDoorCrash(){
		doorHit.Play();
	}

	public void playEnemyHit(){
		enemyHit.Play();
	}
}
