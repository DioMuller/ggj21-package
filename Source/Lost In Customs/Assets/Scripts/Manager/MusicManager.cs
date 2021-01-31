using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    #region Editor Attributes
    [SerializeField, Tooltip("Music List")] private AudioClip[] songs;

    [SerializeField, Tooltip("Audio Source to play the Music")] private AudioSource audioSource = null;
    #endregion // Editor Attributes

    #region Helper Methods
    public void Play(string song)
    {
        var clip = songs.FirstOrDefault(c => c.name == song);

        if( clip != null )
        {
            audioSource.clip = clip;
            audioSource.Play();
            audioSource.loop = true;
        }
    }
    #endregion // Helper Methods

}
