using UnityEngine;
using System.Collections.Generic;

public class AudioMap : MonoBehaviour {

    private Dictionary<int, AudioSource> audioMap;

    private void Awake() {
        audioMap = new Dictionary<int, AudioSource>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void AddToDictionary(int hashID, AudioSource source) {
        try {
            audioMap.Add(hashID, source);
        }
        catch {
            Debug.LogWarning(hashID + " already exists");
        }
    }
        
}
