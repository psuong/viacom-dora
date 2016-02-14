using UnityEngine;
using System.Collections.Generic;
using UIFramework.Singleton;

public class FindList : Singleton<FindList> {
    
	public int foundCount = 0;
    public GameObject continueButton;

    public List<GameObject> accessSprites { get { return sprites; } }

    private List<GameObject> sprites;

    protected override void OnAwake(){
		sprites = new List<GameObject> ();
	}
	// Use this for initialization
	void Start () {
		sprites.AddRange(GameObject.FindGameObjectsWithTag("clickable"));
		int listCount = 0;
		while (listCount < 5){
			int find = Random.Range (0, sprites.Count);
			if (sprites[find].gameObject.tag != "find") {
				sprites[find].gameObject.tag = "find";
				listCount += 1;
				print (sprites [find]);
			}
		}
	}

    public void ActivateButton() {
        continueButton.SetActive(true);
        for (int i = 0; i < sprites.Count; i++) {
            DontDestroyOnLoad(sprites[i]);
            DontDestroyOnLoad(sprites[i].transform.root);
        }
        DontDestroyOnLoad(this);
    }
}
