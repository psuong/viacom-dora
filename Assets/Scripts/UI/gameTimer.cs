using UnityEngine;
using System.Collections;

public class gameTimer : UIScreen
{
	public string startBUtton;
	public string timerText;
	bool pressed = false;
	bool timerIsNotRunning = false;
	int seconds = 0;
	string secondsstring;

	public void startTimer ()
	{
		StartCoroutine ("timer");
	}

	IEnumerator timer ()
	{
		while (!timerIsNotRunning) {
			yield return new WaitForSeconds (1f);
			seconds += 1;
			secondsstring = seconds.ToString();
			SetText (timerText, secondsstring);

		}
	}

	// Update is called once per frame
	//	void Update () {
	//		if (pressed == true) {
	//			mseconds += Time.time * Time.deltaTime;
	//			seconds = Mathf.Floor(mseconds);
	//			if (seconds >= 60) {
	//				minutes += 1;
	//				seconds = 0;
	//			}
	//			if (seconds <= 9) {
	//				SetText (timerText, minutes + ":0" + seconds);
	//			}
	//			else{
	//				SetText (timerText, minutes + ":" + seconds);
	//			}
	////			Debug.Log (minutes + ":" + Mathf.Floor(seconds));
	//		}
	//
	//	}
}
