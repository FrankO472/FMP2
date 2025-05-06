using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenuui;
    public GameObject OptionsMenu;
    public GameObject LevelSelectMenu;
    // Start is called before the first frame update
    void Start()
    {
        MainMenuui.SetActive(true);
        OptionsMenu.SetActive(false);
        LevelSelectMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlay()
    {
        MainMenuui.SetActive(false);
        LevelSelectMenu.SetActive(true);

    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnOptions()
    {
        MainMenuui.SetActive(false);
        OptionsMenu.SetActive(true);
        LevelSelectMenu.SetActive(false);
    }

    public void Onlevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

     public void Onlevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }

     public void Onlevel3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
    }

    public void OnBack()
    {
         MainMenuui.SetActive(true);
        OptionsMenu.SetActive(false);
        LevelSelectMenu.SetActive(false);

    }
}
