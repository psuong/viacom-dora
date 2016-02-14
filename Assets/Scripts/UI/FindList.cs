using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FindList : MonoBehaviour {
	List<GameObject> sprites = new List<GameObject> ();
	public int foundCount = 0;

	void Awake(){
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

}
