using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour {

    /// <summary>
    /// Get the current active scene and and increment it to load the next scene.
    /// </summary>
    public void LoadNextLevel() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);
    }
    
    /// <summary>
    /// Allows buttons to be assigned to load a specific level.
    /// </summary>
    public void LoadCustomScene(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
    }
}
