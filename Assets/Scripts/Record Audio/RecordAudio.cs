using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class RecordAudio : MonoBehaviour {

    private AudioMap map;
    private AudioSource audio;
    public ButtonHashID currentHashID;

    // Use this for initialization
    private void Start() {
        foreach (string device in Microphone.devices) {
            Debug.Log("Name: " + device);
        }
        audio = GetComponent<AudioSource>();
        currentHashID = new ButtonHashID(Animator.StringToHash(gameObject.name));
        map = FindObjectOfType<AudioMap>();
    }

    private void AddToAudioMap() {
        map.AddToDictionary(currentHashID.getHashID, audio);
    }

    public void StartRecordingAudio() {
        audio.clip = Microphone.Start("", true, 10, 44100);
    }

    public void PlayRecordedAudio() {
        audio.Play();
    }
}
