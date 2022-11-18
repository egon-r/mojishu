using System;
using DigitalRuby.Tween;
using Games.Shared.Util.Menu;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Games.Pairs.UI
{
    /// <summary>
    /// The Menu shown when a game of Pairs is finished (usually after matching all cards)
    /// </summary>
    public class GameFinishedMenu : AnimatedMenu
    {
        private MenuManager menuManager;
        public ParticleSystem highscoreParticles;
        public Button nextLevel;
        public Button retryLevel;
        public Button levelSelect;
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI titleText;
        private LevelListItem nextLevelItem = null;
        private LevelListItem currentLevelItem = null;

        void Start()
        {
            levelSelect.onClick.AddListener(levelSelect_clicked);
            retryLevel.onClick.AddListener(retryLevel_clicked);
            nextLevel.onClick.AddListener(nextLevel_clicked);
        }

        private void OnEnable()
        {
            menuManager = gameObject.GetComponentInParent<MenuManager>();
            
            menuManager.GetMenuByType<LevelSelectMenu>(menu =>
            {
                menuManager.GetMenuByType<PlayerHud>(hud =>
                {
                    nextLevelItem = menu.GetLevelLinkedListNode(hud.LevelText.text)?.Next?.Value;
                    currentLevelItem = menu.GetLevelLinkedListNode(hud.LevelText.text)?.Value;
                });
            });
            
            nextLevel.gameObject.SetActive(nextLevelItem != null);
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

        private void retryLevel_clicked()
        {
            menuManager.GetMenuByType<LevelSelectMenu>(menu =>
            {
                menu.PlayLevel(currentLevelItem.GameInitData);
            });
        }

        private void nextLevel_clicked()
        {
            menuManager.GetMenuByType<LevelSelectMenu>(menu =>
            {
                menu.PlayLevel(nextLevelItem.GameInitData);
            });
        }

        private void levelSelect_clicked()
        {
            Time.timeScale = 1;
            var levelSelectMenu = menuManager.GetMenuByType<LevelSelectMenu>(menu =>
            {
                menu.pairsGame.Board.Clear();
            });
            menuManager.HideCurrentAndShow(levelSelectMenu);
        }
    }
}