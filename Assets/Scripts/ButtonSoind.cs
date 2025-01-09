using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSoind : MonoBehaviour
{
    public GameObject pausePanel,muteButtom,unMuteButton;
    public void MuteAllSound()
    {
        AudioListener.volume = 0;
        muteButtom.SetActive(false);
        unMuteButton.SetActive(true);
    }
    public void UnMuteAllSound()
    {
        AudioListener.volume = 1;
        muteButtom.SetActive(true);
        unMuteButton.SetActive(false);
    }
    public void PauseButton()
    {

        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

        if (pausePanel.activeSelf == true)
        {
            pausePanel.SetActive(false);
        }
        else
        {
            pausePanel.SetActive(true);
        }
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void NextLvlButton()
    {
        if (SceneManager.GetActiveScene().buildIndex < 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
        Time.timeScale = 1;
    }

}
