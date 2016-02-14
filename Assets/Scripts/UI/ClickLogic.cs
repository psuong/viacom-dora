using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickLogic : MonoBehaviour {
	bool foundAll = false;
	private FindList count;

	// Use this for initialization
	void Start(){
		count = GameObject.FindObjectOfType<FindList> ();
	}


	public void findCheck(){
		if (gameObject.tag == "find"){
			count.foundCount += 1;
			print (count);
			gameObject.GetComponent<Button> ().interactable = false;

		}
		if (count.foundCount == 5){
			foundAll = true;
			Debug.Log ("DONE");
}
	}
}
