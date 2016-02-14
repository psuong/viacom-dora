using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GridGenerator : MonoBehaviour {

    public GameObject[] gridPanels;

    private FindList listManager;

    private GameObject[] gridObjects;

	// Use this for initialization
	private void Start () {
        listManager = FindObjectOfType<FindList>();
        gridObjects = GameObject.FindGameObjectsWithTag("Grid");
        GeneratePanels();
        DisableInactiveGrids();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void GeneratePanels() {
        for (int i = 0; i < listManager.accessSprites.Count; i++) {
            GridSetUp(gridPanels[i], listManager.accessSprites[i]);
        }
    }

    private void GridSetUp(GameObject gridObject, GameObject spriteObject) {
        for (int i = 0; i < gridObject.GetComponentsInChildren<Image>().Length; i++) {
            if (gridObject.GetComponentsInChildren<Image>()[i].tag == "Sprite") {
                gridObject.GetComponentsInChildren<Image>()[i].sprite = spriteObject.GetComponent<Image>().sprite;
            }
        }
    }

    private void DisableInactiveGrids() {
        for (int i = 0; i < gridObjects.Length; i++) {
            for (int j = 0; j < gridObjects[i].GetComponentsInChildren<Image>().Length; j++) {
                if (gridObjects[i].GetComponentsInChildren<Image>()[j].sprite == null) {
                    gridObjects[i].SetActive(false);
                }
            }
        }
    }
}
