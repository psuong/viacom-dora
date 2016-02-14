using UnityEngine;
using System.Collections;
using UIFramework;

public class HighScore : UIScreen {
	private timeKeeper score;
	public string scorebox;
	string endtime;

	// Use this for initialization
	private void OnEnable () {
		score = FindObjectOfType<timeKeeper> ();
		Debug.Log (score);
		endtime = score.secondsTaken;
		Debug.Log (endtime);
		SetText (scorebox, "You took " + endtime + " seconds to find the items!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
