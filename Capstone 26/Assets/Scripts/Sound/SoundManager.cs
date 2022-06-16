using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource _mainMenuBgm, _gameBgm, _daurBgm, _interactSfx, _buttonSfx, _winSfx, _loseSfx, _effectSource;

    private void Awake()
    {
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

    public void MainMenuBgm()
    {
        _mainMenuBgm.Play();
        _gameBgm.Stop();
        _daurBgm.Stop();
    }
    public void GameplayBgm()
    {
        _mainMenuBgm.Stop();
        _gameBgm.Play();
        _daurBgm.Stop();
    }
    public void DaurBgm()
    {
        _mainMenuBgm.Stop();
        _gameBgm.Stop();
        _daurBgm.Play();
    }

    public void StopBgm()
    {
        _mainMenuBgm.Stop();
        _gameBgm.Stop();
        _daurBgm.Stop();
    }

    public void PlaySound(AudioClip clip){
        _effectSource.PlayOneShot(clip);
    }

    public void BtnSfx()
    {
        _buttonSfx.Play();
    }

    public void InteractSfx()
    {
        _interactSfx.Play();
    }

    public void WinSfx()
    {
        _winSfx.Play();
    }

    public void LoseSfx()
    {
        _loseSfx.Play();
    }
}
