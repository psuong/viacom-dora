using UnityEngine;
using System.Collections;

public class StopRecord : MonoBehaviour {

    public RecordAudio recordingButton;

    private AudioMap map;
    private AudioSource source;
    private int hashID;

    private void Awake() {
        map = FindObjectOfType<AudioMap>();
        source = recordingButton.GetComponent<AudioSource>();
    }

	// Use this for initialization
	void Start () {
        Invoke("SetHashID", 10f);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void SetHashID() {
        hashID = recordingButton.currentHashID.getHashID;
    }

    public void StopRecordingAudio() {
        if (Microphone.IsRecording("")) {
            Microphone.End("");
            map.AddToDictionary(hashID, source.clip);
            recordingButton.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
        Microphone.End("");
        map.AddToDictionary(hashID, source.clip);
        recordingButton.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
