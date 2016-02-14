using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemManager : MonoBehaviour {

    public Image[] imagesToFind;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        for (int i = 0; i < imagesToFind.Length; i++) {
            if (other.gameObject.name == imagesToFind[i].name) {
                Debug.Log("True");
            }        
        }      
    }
}
