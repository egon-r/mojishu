using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PairsHudManager : MonoBehaviour
{
    public Button pause;
    public Button resume;
    public Button exit;
    public Button mainMenu;
    public CanvasGroup levelSelection;
    public CanvasGroup playerHud;
    public CanvasGroup pauseMenu;
    
    void Start()
    {
        pause.onClick.AddListener(pause_clicked);
        resume.onClick.AddListener(resume_clicked);
        exit.onClick.AddListener(exit_clicked);
        mainMenu.onClick.AddListener(mainMenu_clicked);
        
        ShowMenu(playerHud);
    }

    private void mainMenu_clicked()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    private void exit_clicked()
    {
        Application.Quit();
    }

    private void resume_clicked()
    {
        ShowMenu(playerHud);
        Time.timeScale = 1;
    }

    private void pause_clicked()
    {
        Time.timeScale = 0;
        ShowMenu(pauseMenu);
    }

    private void HideMenu(CanvasGroup menu)
    {
        menu.alpha = 0;
        menu.gameObject.SetActive(false);
    }
    
    private void ShowMenu(CanvasGroup menu, bool hideOthers = true)
    {
        if (hideOthers)
        {
            HideMenu(levelSelection);
            HideMenu(playerHud);
            HideMenu(pauseMenu);
        }

        menu.alpha = 1;
        menu.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
