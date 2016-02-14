using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UIFramework.Singleton;

public class FindList : Singleton<FindList> {
    
	public int foundCount = 0;
    public GameObject continueButton;
    public GameObject itemTextGroup;

    public List<GameObject> accessSprites { get { return sprites; } }
    public Text[] accessTextItems { get { return textItems; } } 

    private List<GameObject> sprites;
    private Text[] textItems;

    protected override void OnAwake(){
		sprites = new List<GameObject> ();
        textItems = itemTextGroup.GetComponentsInChildren<Text>();
	}
	// Use this for initialization
	void Start () {
		sprites.AddRange(GameObject.FindGameObjectsWithTag("clickable"));
		int listCount = 0;
		while (listCount < 5){
			int find = Random.Range (0, sprites.Count);
			if (sprites[find].gameObject.tag != "find") {
                textItems[listCount].text = sprites[find].gameObject.name;
				sprites[find].gameObject.tag = "find";
				listCount += 1;
				print (sprites [find]);
			}
		}
	}

    public void ActivateButton() {
        continueButton.SetActive(true);
    }
}
