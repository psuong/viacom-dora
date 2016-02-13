using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class RecordAudio : MonoBehaviour {

    public ButtonHashID currentHashID;

    /// <summary>
    /// Should the audioclip be on "loopable?"
    /// </summary>
    public bool isLoopingClip;

    private AudioMap map;
    private AudioSource audio;

    // Use this for initialization
    private void Start() {
        foreach (string device in Microphone.devices) {
            Debug.Log("Name: " + device);
        }
        audio = GetComponent<AudioSource>();
        currentHashID = new ButtonHashID(Animator.StringToHash(gameObject.name));
        map = FindObjectOfType<AudioMap>();
    }

    public void StartRecordingAudio() {
        audio.clip = Microphone.Start("", isLoopingClip, 5, 44100);
        Invoke("AddAudioClip", 5f);
    }

    private void AddAudioClip() {
        map.AddToDictionary(currentHashID.getHashID, audio.clip);
    }
}
