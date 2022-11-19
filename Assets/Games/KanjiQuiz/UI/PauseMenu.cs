using Games.Shared.Util.Menu;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Games.KanjiQuiz.UI
{
    public class PauseMenu : AnimatedMenu
    {
        public KanjiQuizGame Game;
        public Button ResumeButton;
        public Button LevelSelectButton;
        public Button MainMenuButton;

        // Start is called before the first frame update
        void Start()
        {
            ResumeButton.onClick.AddListener(ResumeButton_clicked);
            LevelSelectButton.onClick.AddListener(LevelSelectButton_clicked);
            MainMenuButton.onClick.AddListener(MainMenuButton_clicked);
        }

        private void MainMenuButton_clicked()
        {
            Time.timeScale = 1;
            Game.Hide();
            SceneManager.LoadScene("Scenes/MainMenu");
        }

        private void LevelSelectButton_clicked()
        {
            Time.timeScale = 1;
            Game.Hide();
            var menuManager = gameObject.GetComponentInParent<MenuManager>();
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<LevelSelectMenu>());
        }

        private void ResumeButton_clicked()
        {
            Time.timeScale = 1;
            var menuManager = gameObject.GetComponentInParent<MenuManager>();
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<PlayerHud>(), parallel: true);
        }
        
    }
}
