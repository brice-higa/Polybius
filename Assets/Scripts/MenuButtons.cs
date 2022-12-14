using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    
    // Variables used to show/hide panels
    public GameObject MenuPanel;
    public GameObject OptionsPanel;
    public GameObject HelpPanel;

    // Variables used for audio
    public AudioMixer audioMixer;
    public Slider volumeSlider;

    // Show only the Main Menu Panel at the start
    void Start()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
        HelpPanel.SetActive(false);
    }

    void Update()
    {
        
    }

    // BackToMenu button
    public void SwitchToMain()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
        HelpPanel.SetActive(false);
    }

    // Options button
    public void SwitchToOptions()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }

    // Help button
    public void SwitchToHelp()
    {
        MenuPanel.SetActive(false);
        HelpPanel.SetActive(true);
    }

    // Exit button
    public void ExitFunction()
    {
        Application.Quit();
    }

    // Switch scene to play game
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    //currently not working
    public void SetVolume(float sliderValue)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }

    //currently not in use
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    //Difficulty buttons
    //Store information in PlayerPrefs to persist across scenes
    public void SetDifficultyEasy()
    {
        PlayerPrefs.SetFloat("EnemySpawnTimerIncrease", 2); // Increase time between enemy spawns
    }
    public void SetDifficultyMedium()
    {
        PlayerPrefs.SetFloat("EnemySpawnTimerIncrease", 0);
    }
    public void SetDifficultyHard()
    {
        PlayerPrefs.SetFloat("EnemySpawnTimerIncrease", -2); //Negative value so enemies spawn more often
    }
}
