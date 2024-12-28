using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _sliderOfVolume;
    [SerializeField] private Slider _sliderOfButtonsVolume;
    [SerializeField] private Slider _sliderOfBackgroundVolume;

    private string _nameOfMasterVolume = "MasterVolume";
    private string _nameOfButtonsMusic = "VolumeOfButtons";
    private string _nameOfBackgroundMusic = "BackgroundMusic";

    public void Awake()
    {
        _sliderOfVolume.onValueChanged.AddListener(SetMasterVolume);
        _sliderOfButtonsVolume.onValueChanged.AddListener(SetButtonsVolume);
        _sliderOfBackgroundVolume.onValueChanged.AddListener(SetBackgroundVolume);
    }

    protected void OnDestroy()
    {
        _sliderOfVolume.onValueChanged.RemoveListener(SetMasterVolume);
        _sliderOfButtonsVolume.onValueChanged.RemoveListener(SetButtonsVolume);
        _sliderOfBackgroundVolume.onValueChanged.RemoveListener(SetBackgroundVolume);
    }

    public void SetMasterVolume(float level)
    {
        float volume = Mathf.Log10(level) * 20;
        _audioMixer.SetFloat(_nameOfMasterVolume, volume);
    }

    public void SetBackgroundVolume(float level)
    {
        float volume = Mathf.Log10(level) * 20;
        _audioMixer.SetFloat(_nameOfBackgroundMusic, volume);
    }

    public void SetButtonsVolume(float level)
    {
        float volume = Mathf.Log10(level) * 20;
        _audioMixer.SetFloat(_nameOfButtonsMusic, volume);
    }
}
