using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickLogic : MonoBehaviour {

	private bool foundAll = false;
	private FindList count;

	// Use this for initialization
	void Start(){
		count = FindObjectOfType<FindList>();
	}

	public void findCheck(){
		if (gameObject.tag == "find"){
			count.foundCount += 1;
			gameObject.GetComponent<Button> ().interactable = false;
            Text text = GetTextItem();
            Debug.Log(text.name);
            if (text != null) {
                text.color = Color.red;
            }
		}
		if (count.foundCount == 5){
			foundAll = true;
            count.continueButton.SetActive(true);
        }
        StopAllCoroutines();
	}

    private Text GetTextItem() {
        for (int i = 0; i < count.accessTextItems.Length; i++) {
            if (gameObject.name == count.accessTextItems[i].text) {
                return count.accessTextItems[i];
            }
        }
        return null;
    }
}
