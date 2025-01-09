using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu, lvlSelectMenu, authorMenu;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LvlSelectedMenu()
    {
        lvlSelectMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void MainMenuSelected()
    {
        lvlSelectMenu.SetActive(false);
        authorMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void LvlSelected(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }
    public void AuthorSelectedMenu()
    {
        authorMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
}
