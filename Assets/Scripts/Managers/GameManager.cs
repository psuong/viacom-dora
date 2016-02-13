using UnityEngine;
using System.Collections;

public enum GameStates {isRunning, isPaused}

public class GameManager : MonoBehaviour {
    
    public int timeToWait = 5;

    private GameStates gameState;

    private void OnAwake() {
        gameState = GameStates.isPaused;
    }

	// Use this for initialization
	void Start () {
	    if (gameState != GameStates.isPaused) {
            gameState = GameStates.isPaused;       
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private IEnumerator PauseGameForSetTime() {
        yield return new WaitForSeconds(timeToWait);
    }
}
