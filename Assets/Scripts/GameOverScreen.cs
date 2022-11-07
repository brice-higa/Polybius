using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{

    public GameObject GameOverGUI;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        GameOverGUI.SetActive(false); // Game over screen does not show by default

        // find the player, this should ONLY work if the player starts in the scene
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        // if player dies
        if(player == null)
        {
            GameOverGUI.SetActive(true); // show game over screen after the player dies
        }

    }

    // Switch to main menu scene
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
