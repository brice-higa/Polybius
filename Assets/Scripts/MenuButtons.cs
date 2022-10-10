using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    
    public GameObject MenuPanel;
    public GameObject OptionsPanel;

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
        SceneManager.LoadScene("BriceTestScene");
    }


}
