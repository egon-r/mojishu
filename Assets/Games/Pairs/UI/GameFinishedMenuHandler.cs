using System;
using DigitalRuby.Tween;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Games.Pairs.UI
{
    /// <summary>
    /// The Menu shown when a game of Pairs is finished (usually after matching all cards)
    /// </summary>
    public class GameFinishedMenuHandler : MonoBehaviour
    {
        public RectTransform rootPanel;
        public PairsMenuManager menuManager;
        public Button nextLevel;
        public Button levelSelect;
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI titleText;
        public string CurrentLevelName = "unknown_level";
        private LevelListItem nextLevelItem = null;

        void Start()
        {
            levelSelect.onClick.AddListener(levelSelect_clicked);
            nextLevel.onClick.AddListener(nextLevel_clicked);
        }
        
        private void OnEnable()
        {
            nextLevelItem = menuManager.levelSelectMenuHandler.GetNextLevel(CurrentLevelName);
            if (nextLevelItem == null)
            {
                nextLevel.gameObject.SetActive(false);
            }
            else
            {
                nextLevel.gameObject.SetActive(true);
            }
        }

        public void setScoreText(int score100)
        {
            scoreText.text = score100 + "%";
            scoreText.color = PairsUtils.getHighscoreColor(score100);
        }

        public void setTitleText(string text)
        {
            titleText.text = text;
        }

        private void nextLevel_clicked()
        {
            menuManager.levelSelectMenuHandler.PlayLevel(nextLevelItem.GameInitData);
        }

        private void levelSelect_clicked()
        {
            Time.timeScale = 1;
            menuManager.levelSelectMenuHandler.GetComponent<LevelSelectMenuHandler>().pairsGame.Board.ClearBoard();
            menuManager.ShowMenu(menuManager.levelSelectMenuHandler.gameObject);
        }

        public void SlideInFromTop(bool reverse = false)
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
                1.0f, TweenScaleFunctions.CubicEaseOut,
                slideIn
            );
        }
    }
}