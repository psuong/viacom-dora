using UnityEngine;
using System.Collections;

public class timeKeeper : MonoBehaviour {
	public string secondsTaken;
	private gameTimer timer;

	// Use this for initialization
	void Start () {
		timer = FindObjectOfType<gameTimer> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		secondsTaken = timer.secondsString;
	
	}
}
