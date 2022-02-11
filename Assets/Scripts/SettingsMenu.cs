using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolumne (float volume)
    {
        audioMixer.SetFloat("volume", volume); 
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen (bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        Debug.Log("ha cambiaso");
    }

    public void SetFps (int fps)
    {
        if (fps == 0)
        {
            Application.targetFrameRate = -1;
        }
        else if( fps == 1)
        {
            Application.targetFrameRate = 30;
        }
        else if (fps == 2)
        {
            Application.targetFrameRate = 60;
        }
        else if (fps == 3)
        {
            Application.targetFrameRate = 90;
        }
        else if (fps == 4)
        {
            Application.targetFrameRate = 120;
        }
        else if (fps == 5)
        {
            Application.targetFrameRate = 144;
        }
        else
        {
            Application.targetFrameRate = 60;
        }
        
    }
}
