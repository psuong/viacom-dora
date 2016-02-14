using UnityEngine;
using System.Collections;
using UIFramework.Singleton;

public class HighScore : UIScreen {
	private gameTimer score;
	public string scorebox;
	string endtime;

	// Use this for initialization
	void Start () {
		score = FindObjectOfType<gameTimer> ();
		endtime = score.secondsString;
		SetText (scorebox, "You took " + endtime + " seconds to find the items!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
