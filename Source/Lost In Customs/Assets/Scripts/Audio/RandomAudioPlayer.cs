using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioPlayer : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Audio Clip List")] private AudioClip[] clips;

    [SerializeField, Tooltip("Audio Source to play the Clip")] private AudioSource audioSource = null;
    #endregion // Editor Attributes

    #region Helper Methods
    public void PlayAudio()
    {
        if( !audioSource.isPlaying )
        {
            var index = Random.Range(0, clips.Length);
            audioSource.clip = clips[index];
            audioSource.Play();
        }
    }
    #endregion // Helper Methods
}
