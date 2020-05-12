using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    private AudioSource _audioSource;
     private void Awake()
     {
         DontDestroyOnLoad(transform.gameObject); // prevent the audio from beign stopped when switch the scenes
         _audioSource = GetComponent<AudioSource>(); // gett thee audio clip
     }
 
     public void PlayMusic()
     {
         if (_audioSource.isPlaying) return; // if the audio is already playing exit the function
         _audioSource.Play(); // play the audio 
     }
 
     public void StopMusic()
     {
         _audioSource.Stop(); // stop the audio
     }
}
