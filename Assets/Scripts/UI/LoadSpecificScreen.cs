using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadSpecificScreen : LoadScene {
    
    public gameTimer timerScreen;
    public GameObject listOfItems;

    private FindList listManager;
    private GameObject[] findSprites;
    private GameObject[] clickableSprites;
    private Image[] untaggedSprites;

    private void Start() {
        listManager = FindObjectOfType<FindList>();
        findSprites = GameObject.FindGameObjectsWithTag("find");
        clickableSprites = GameObject.FindGameObjectsWithTag("clickable");
        untaggedSprites = FindObjectsOfType<Image>();
    }

    public override void LoadNextLevel() {
        DontDestroyOnLoad(listManager.gameObject);
        for (int i = 0; i < findSprites.Length; i++) {
            findSprites[i].SetActive(false);
            DontDestroyOnLoad(findSprites[i].transform.root);
        }
        for (int i = 0; i < clickableSprites.Length; i++) {
            clickableSprites[i].SetActive(false);
            DontDestroyOnLoad(findSprites[i].transform.root);
        }
        for (int i = 0; i < untaggedSprites.Length; i++) {
            if (untaggedSprites[i].tag != "clickable" || untaggedSprites[i].tag != "find") {
                untaggedSprites[i].gameObject.SetActive(false);
            }
        }
        FindObjectOfType<Button>().gameObject.SetActive(false);
        timerScreen.StopTimer();
        timerScreen.gameObject.SetActive(false);
        listOfItems.SetActive(false);
        StopAllCoroutines();
        base.LoadNextLevel();
    }
}
