using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SoundSystem : MonoBehaviour
{
    [Space]
    [Header("Audio source")]
    public AudioSource source;

    [Space]
    [Tooltip("Sound of the game")]
    [Header("Sounds")]
    public AudioClip clickSoundMenu;
    public AudioClip sellFishSound;
    public AudioClip buyPowerUpSound;
    public AudioClip clickAFish;

    public void OnClickAFish()
    {
        source.clip = clickAFish;
        source.Play();
    }

    public void OnClickMenu()
    {
        source.clip = clickSoundMenu;
        source.Play();
    }

    public void OnSellFish()
    {
        source.clip = sellFishSound;
        source.Play();
    }

    public void OnBuyPowerUp()
    {
        source.clip = buyPowerUpSound;
        source.Play();
    }

}
