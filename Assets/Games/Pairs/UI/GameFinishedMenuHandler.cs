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
        public PairsMenuManager menuManager;
        public Button nextLevel;
        public Button levelSelect;
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI titleText;
    
        void Start()
        {
            levelSelect.onClick.AddListener(levelSelect_clicked);
            nextLevel.onClick.AddListener(nextLevel_clicked);
        }

        public void setScoreText(string text)
        {
            scoreText.text = text;
        }
    
        public void setTitleText(string text)
        {
            titleText.text = text;
        }

        private void nextLevel_clicked()
        {
            Debug.Log("Next Level...");
        }

        private void levelSelect_clicked()
        {
            Time.timeScale = 1;
            menuManager.levelSelectMenuHandler.GetComponent<LevelSelectMenuHandler>().pairsGame.Board.ClearBoard();
            menuManager.ShowMenu(menuManager.levelSelectMenuHandler.gameObject);
        }
    }
}
