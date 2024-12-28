using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSwitch : MonoBehaviour
{
    private bool _isOn = true;

    public void ChangeStateSound()
    {
        AudioListener.volume = _isOn ? 1f : 0f;
        _isOn = !_isOn;
    }
}
