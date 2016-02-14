using UnityEngine;
using System.Collections;

public class gameTimer : UIScreen
{
	public string startButton;
	public string timerText;
	bool pressed = false;
	bool timerIsNotRunning = false;
	int seconds = 0;
	string secondsString;

    protected override void Start() {
        base.Start();
        startTimer();
    }        

	public void startTimer ()
	{
		StartCoroutine ("timer");
	}

    public void StopTimer() {
        StopCoroutine("timer");
    }

	private IEnumerator timer ()
	{
		while (!timerIsNotRunning) {
			yield return new WaitForSeconds (1f);
			seconds += 1;
			secondsString = seconds.ToString();
			SetText (timerText, secondsString);
		}
	}

}
