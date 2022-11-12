using System;
using DigitalRuby.Tween;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Games.Pairs.UI
{
    /// <summary>
    /// Contains all functions of the pause menu
    /// </summary>
    public class PauseMenuHandler : MonoBehaviour
    {
        public PairsMenuManager menuManager;
        public RectTransform rootPanel;
        public Button resume;
        public Button levelSelect;
        public Button mainMenu;
    
        // Start is called before the first frame update
        void Start()
        {
            resume.onClick.AddListener(resume_clicked);
            levelSelect.onClick.AddListener(levelSelect_clicked);
            mainMenu.onClick.AddListener(mainMenu_clicked);
        }

        private void mainMenu_clicked()
        {
            Time.timeScale = 1;
            SlideInFromTop(_ =>
            {
                SceneManager.LoadScene("Scenes/MainMenu");
            }, true);
        }

        private void levelSelect_clicked()
        {
            Time.timeScale = 1;
            SlideInFromTop(_ =>
            {
                menuManager.levelSelectMenuHandler.GetComponent<LevelSelectMenuHandler>().pairsGame.Board.ClearBoard();
                menuManager.ShowMenu(menuManager.levelSelectMenuHandler.gameObject);
            }, true);
        }

        private void resume_clicked()
        {
            Time.timeScale = 1;
            SlideInFromTop(_ => menuManager.ShowMenu(menuManager.playerHud.gameObject), true);
        }

        public void SlideInFromTop(Action<ITween> onComplete, bool reverse = false)
        {
            System.Action<ITween<Vector3>> slideIn = t =>
            {
                rootPanel.GetComponent<RectTransform>().localPosition = t.CurrentValue;
            };
            var slideStart = new Vector3(0, 1700, 0);
            var slideEnd = Vector3.zero;
            rootPanel.gameObject.Tween(
                slideIn,
                reverse ? slideEnd : slideStart, 
                reverse ? slideStart : slideEnd,
                0.4f, TweenScaleFunctions.CubicEaseOut,
                slideIn,
                onComplete
            );
        }
    }
}
