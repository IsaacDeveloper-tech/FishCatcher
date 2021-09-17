using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class MusicSystem : MonoBehaviour
{
    [Header("Ambient music clip")]
    public AudioClip audioClip;

    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        source.clip = audioClip;
        source.Play();
    }
}
