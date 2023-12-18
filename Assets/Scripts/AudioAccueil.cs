using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioAccueil : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;

    public void AjusterVolumeMusique(float volume)
    {
       
        audioMixer.SetFloat("Musique", volume);
    }

  
}
