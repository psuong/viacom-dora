using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlayAudio : MonoBehaviour {

    public RecordAudio recordingButton;

    private AudioMap map;
    private AudioSource source;
    private int hashID;

    private void Awake() {
        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start () {
        map = FindObjectOfType<AudioMap>();
        Invoke("SetHashID", 10);
	}

    private void SetHashID() {
        hashID = recordingButton.currentHashID.getHashID;
    }

    /// <summary>
    /// Plays the recorded audio clip.
    /// </summary>
    public void PlayRecordedAudio() {
        source.clip = map.GetAudioClip(hashID);
        source.Play();
    }
}
