using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour

    


{
    public static AudioManager Instance = null;
    AudioSource _audioSource;
   public void PlaySong(AudioClip clip)
   {
       _audioSource.clip = clip;
       _audioSource.Play();
   }
}
