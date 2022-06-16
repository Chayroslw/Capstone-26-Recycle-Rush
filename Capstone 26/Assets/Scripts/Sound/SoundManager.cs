using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public static SoundManager Instance;

   [SerializeField] private AudioSource _musicSource, _effectSource;

    [Header("Sound Sfx")]
    public AudioSource button;
    public AudioSource lose;
    public AudioSource pickUp;
    private void Awake() {
    if (Instance == null)
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    else
    {
        Destroy(gameObject);
    }
   }

    public void PlaySound(AudioClip clip){
        _effectSource.PlayOneShot(clip);
    }

    public void ButtonSFX()
    {
        button.Play();
    }

    public void LoseSFX()
    {
        lose.Play();
    }

    public void PickUpSFX()
    {
        pickUp.Play();
    }
}
