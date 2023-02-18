using System;
using DigitalRuby.Tween;
using Games.Shared.Util.Menu;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Games.Pairs.UI
{
    /// <summary>
    /// Contains all functions of the pause menu
    /// </summary>
    public class PauseMenu : AnimatedMenu
    {
        public Button Resume;
        public Button LevelSelect;
        public Button MainMenu;
        private MenuManager menuManager;

        // Start is called before the first frame update
        void Start()
        {
            menuManager = getMenuManager();
            Resume.onClick.AddListener(resume_clicked);
            LevelSelect.onClick.AddListener(levelSelect_clicked);
            MainMenu.onClick.AddListener(mainMenu_clicked);
        }

        private void mainMenu_clicked()
        {
            Time.timeScale = 1;
            menuManager.HideCurrentMenu(() =>
            {
                SceneManager.LoadScene("Scenes/MainMenu");
            });
        }

        private void levelSelect_clicked()
        {
            Time.timeScale = 1;
            menuManager.GetMenuByType<LevelSelectMenu>(menu =>
            {
                menu.pairsGame.Board.HideBoard();
            });
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<LevelSelectMenu>(), parallel: true);
        }

        private void resume_clicked()
        {
            Time.timeScale = 1;
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<PlayerHud>(), parallel: true);
        }
    }
}
