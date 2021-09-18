using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundConfiguration : MonoBehaviour
{

    public AudioMixer mixer;

    public void SetMusicVolume(float pvolume)
    {
        mixer.SetFloat("musicVolume", pvolume);
    }

    public void SetSoundsVolume(float pvolume)
    {
        mixer.SetFloat("soundsVolume", pvolume);
    }
}
