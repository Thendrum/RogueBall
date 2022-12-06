using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{
    
    public AudioMixer AudioMixer;
    public AudioMixer MusicMixer;
    public void VolumeControl(float volume)
    {
        AudioMixer.SetFloat("MasterVolume", volume);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void MusicControl(float volume)
    {
        AudioMixer.SetFloat("Music", volume);
    }
}

