using UnityEngine;
using System.Collections;

public class PlaySpanish : MonoBehaviour {
	AudioSource spanish;

	// Use this for initialization
	void Start () {
		spanish = GetComponent<AudioSource> ();
	
	}
	public void playSpanish(){
		spanish.Play ();
	}

}
