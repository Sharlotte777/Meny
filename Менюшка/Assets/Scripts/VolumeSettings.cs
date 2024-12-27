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

    public void SetMasterVolume(float level)
    {
        _audioMixer.SetFloat(_nameOfMasterVolume, Mathf.Log10(level) * 20);
    }

    public void SetBackgroundVolume(float level)
    {
        _audioMixer.SetFloat(_nameOfBackgroundMusic, Mathf.Log10(level) * 20);
    }

    public void SetButtonsVolume(float level)
    {
        _audioMixer.SetFloat(_nameOfButtonsMusic, Mathf.Log10(level) * 20);
    }
}
