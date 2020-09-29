using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ConfigManager : MonoBehaviour
{
    public GameObject settingsWindow;
    public GameObject settingsButton;
    public GameObject controlsWindow;
    public GameObject soundWindow;
    public GameObject pauseColor;
    public AudioMixer audioMixer;

   
    public void ChangeVfxVolume(float volume)
    {
        audioMixer.SetFloat("FX", volume);
    }
    public void ChangeBackgroundVolume(float volume)
    {
        audioMixer.SetFloat("BackgroundMusic", volume);
    }
    public void ChangeUiVolume(float volume)
    {
        audioMixer.SetFloat("UI", volume);
    }
    public void OpenSettingsWindow()
    {
        pauseColor.SetActive(true);
        settingsWindow.SetActive(true);
        settingsButton.SetActive(false);
        Time.timeScale = 0;
    }
    public void CloseSettingsWindow()
    {
        pauseColor.SetActive(false);
        settingsWindow.SetActive(false);
        settingsButton.SetActive(true);
        Time.timeScale = 1;
    }
    public void CloseControlsWindow()
    {
        controlsWindow.SetActive(false);
        settingsWindow.SetActive(true);
        settingsButton.SetActive(false);
        soundWindow.SetActive(false);
    }
    public void OpenControlsWindow()
    {
        controlsWindow.SetActive(true);
        settingsWindow.SetActive(false);
        settingsButton.SetActive(false);
        soundWindow.SetActive(false);
    }
    public void CloseSoundWindow()
    {
        soundWindow.SetActive(false);
        controlsWindow.SetActive(false);
        settingsWindow.SetActive(true);
        settingsButton.SetActive(false);
    }
    public void OpenSoundsWindow()
    {
        soundWindow.SetActive(true);
        controlsWindow.SetActive(false);
        settingsWindow.SetActive(false);
        settingsButton.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
