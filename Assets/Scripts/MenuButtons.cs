using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    
    public GameObject MenuPanel;
    public GameObject OptionsPanel;

    public AudioMixer audioMixer;
    public Slider volumeSlider;

    public double difficultyMultiplier = 1;

    // Show only the Main Menu Panel at the start
    void Start()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }

    void Update()
    {
        
    }

    // BackToMenu button
    public void SwitchToMain()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }

    // Options button
    public void SwitchToOptions()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(true);
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


    public void SetVolume(float sliderValue)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetDifficultyEasy()
    {
        difficultyMultiplier = 0.75;
    }

    public void SetDifficultyMedium()
    {
        difficultyMultiplier = 1;
    }

    public void SetDifficultyHard()
    {
        difficultyMultiplier = 1.25;
    }
}
