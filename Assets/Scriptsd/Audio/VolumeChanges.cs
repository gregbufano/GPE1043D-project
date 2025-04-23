using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeChanges : MonoBehaviour
{
    public AudioMixer NewAudioMixer;
    public Slider musicVolumeSlider;
    public Slider sfxVolumeSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onMusicVolumeChange();
        onSFXVolumeChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onMusicVolumeChange()
{
    float newMusicVolume = musicVolumeSlider.value;
    if (newMusicVolume <= 0)
    {
        newMusicVolume = -80;
    } else
    {
        newMusicVolume = Mathf.Log10(newMusicVolume);
        newMusicVolume = newMusicVolume* 20;
    }
    NewAudioMixer.SetFloat("AudioVolume", newMusicVolume);
}

    public void onSFXVolumeChange()
    {
        float newSFXVolume = sfxVolumeSlider.value;
    if (newSFXVolume <= 0)
    {
        newSFXVolume = -80;
    } else
    {
        newSFXVolume = Mathf.Log10(newSFXVolume);
        newSFXVolume = newSFXVolume* 20;
    }
    NewAudioMixer.SetFloat("SFXVolume", newSFXVolume);
    }
}
