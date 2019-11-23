using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject optionsMenu;

    [SerializeField]
    private GameObject mainMenu;

    public void Options()
    {

        if (optionsMenu.activeSelf)
        {
            mainMenu.SetActive(true);
            optionsMenu.SetActive(false);
        }
        else
        {
            mainMenu.SetActive(false);
            optionsMenu.SetActive(true);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
