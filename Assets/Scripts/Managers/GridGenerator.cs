using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GridGenerator : MonoBehaviour {

    public GameObject gridPanel;

    private FindList listManager;

    private GameObject[] gridObjects;

	// Use this for initialization
	private void Start () {
        listManager = FindObjectOfType<FindList>();
        gridObjects = GameObject.FindGameObjectsWithTag("Grid");
        Invoke("GeneratePanels", 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void GeneratePanels() {
        for (int i = 0; i < listManager.accessSprites.Count; i++) {
            Debug.Log(listManager.accessSprites[i].name);
        }
    }

    private void GridSetUp(GameObject gridObject, GameObject spriteObject) {
        gridObject.GetComponentInChildren<Image>().sprite = spriteObject.GetComponent<Image>().sprite;
        Debug.Log(gridObject.name + " " + spriteObject.name);
    }
}
