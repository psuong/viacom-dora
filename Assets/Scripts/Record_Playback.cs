using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;



public class Record_Playback : MonoBehaviour {
	protected Dictionary<Button, AudioClip> audioDictionary;


	// Use this for initialization
	void Start () {
		Application.RequestUserAuthorization;
		AudioClip Button = Microphone.Start (null, false, 5, 44100);
        audioDictionary.Add= (Button,a)
        a.Play();
        



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
