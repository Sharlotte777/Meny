using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SoundSwitch : MonoBehaviour
{
    private bool _isOn = true;

    private void OnEnable()
    {
        ChangeStateSound();
    }

    public void ChangeStateSound()
    {
        AudioListener.volume = _isOn ? 1f : 0f;
        _isOn = !_isOn;
    }
}
