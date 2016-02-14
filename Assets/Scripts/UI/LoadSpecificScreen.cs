using UnityEngine;
using System.Collections;

public class LoadSpecificScreen : LoadScene {

    private FindList listManager;
    private GameObject[] sprites;

    private void Start() {
        listManager = FindObjectOfType<FindList>();
        sprites = GameObject.FindGameObjectsWithTag("find");
    }

    public override void LoadNextLevel() {
        DontDestroyOnLoad(listManager.gameObject);
        for (int i = 0; i < sprites.Length; i++) {
            DontDestroyOnLoad(sprites[i].transform.root);
        }
        base.LoadNextLevel();
    }
}
