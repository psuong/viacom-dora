using UnityEngine;
using System.Collections;

public class RecordingBar : UIScreen {
	public string timeBar;
	bool pressed = false;
	float barFill= 0f;
	float recordTime = 5f;


	public void buttonPresssed(){
		pressed = true;
	}
	void Update(){
		if (pressed == true) {
			recordTime -= Time.deltaTime;
			float barFill = (5 - recordTime)/5;
			SetImageFill (timeBar, barFill);
		}
	}
}
