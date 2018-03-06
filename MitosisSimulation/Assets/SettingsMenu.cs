using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;
    public Dropdown qualitySettingsDropdown;

    Resolution[] resoltions;

    //QualitySettings
    public string[] qualities;

    void Start()
    {
        resoltions = Screen.resolutions;

        //Clear all options stored in the dropdown menu
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        //Create a list of strings for AddOptions Function 
        for (int i = 0; i < resoltions.Length; i++)
        {
            string option = resoltions[i].width + " x " + resoltions[i].height;
            options.Add(option);

            if (resoltions[i].width == Screen.currentResolution.width && 
                resoltions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex; //Set Screen to the correct Default
        resolutionDropdown.RefreshShownValue();

        //Quality Settings
        List<string> options2 = new List<string>();
        qualities = QualitySettings.names;
        options2 = new List<string>(qualities);
        qualitySettingsDropdown.ClearOptions();
        
        qualitySettingsDropdown.AddOptions(options2);
        qualitySettingsDropdown.value = QualitySettings.GetQualityLevel();
        qualitySettingsDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resoltions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
