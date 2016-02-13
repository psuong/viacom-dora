using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Stores all of the Audioclips recorded by the user.
/// </summary>
public class AudioMap : MonoBehaviour {

    /// <summary>
    /// Maps all audioclips to a hash ID, such that multiple buttons can access the same audio file.
    /// </summary>
    private Dictionary<int, AudioClip> audioMap;

    private void Awake() {
        audioMap = new Dictionary<int, AudioClip>();
    }
    
    /// <summary>
    /// Adds an Audio clip and button ID to the dictionary.
    /// </summary>
    /// <param name="hashID"></param>
    /// <param name="clip"></param>
    public void AddToDictionary(int hashID, AudioClip clip) {
        try {
            audioMap.Add(hashID, clip);
        }
        catch {
            Debug.LogWarning(hashID + " already exists, updating the current Value instead");
            audioMap[hashID] = clip;
        }
    }

    /// <summary>
    /// Returns an instance of the audioclip that's recorded.
    /// </summary>
    /// <param name="hashID"></param>
    /// <returns></returns>
    public AudioClip GetAudioClip(int hashID) {
        return audioMap[hashID];
    }
        
}
