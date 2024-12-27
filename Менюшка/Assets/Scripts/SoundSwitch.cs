using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSwitch : MonoBehaviour
{
    private bool _isOn = true;

    public void OnOffSounds()
    {
        if (_isOn )
        {
            AudioListener.volume = 0f;
            _isOn = false;
        }
        else if (_isOn == false )
        {
            AudioListener.volume = 1f;
            _isOn = true;
        }
    }
}
