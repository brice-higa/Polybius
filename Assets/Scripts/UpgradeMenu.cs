using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradeMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static int HPcost = 10;
    public static int FRcost = 5;

    public GameObject upgradeMenuUI;
    public GameObject dangerC;
    public GameObject dangerI;

    private void Start()
    {
        HPcost = 10;
        FRcost = 5;
        upgradeMenuUI.SetActive(false);
        dangerC.SetActive(false);
        dangerI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.P))
        {
            dangerC.SetActive(false);
            dangerI.SetActive(false);
            if (GameIsPaused)
                Resume();
            else
                Pause();
            dangerC.SetActive(false);
            dangerI.SetActive(false);
        }
    }

    public void Resume()
    {
        upgradeMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        upgradeMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("MainMenu");
    }

    public void hpUpgrade()
    {
        if (DamageHandler.copper >= HPcost)
        {
            DamageHandler.copper -= HPcost;
            DamageHandler.maxHealth += 10;
            HPcost += 5;
        } else
        {
            dangerC.SetActive(true);
        }
    }

    public void frUpgrade()
    {
        if (DamageHandler.iron >= FRcost)
        {
            DamageHandler.iron -= FRcost;
            PlayerShooting.fireDelay -= 0.1f;
            PlayerAutoShooting.fireDelay -= 0.1f;
            FRcost += 5;
        } else
        {
            dangerI.SetActive(true);
        }
    }
}
