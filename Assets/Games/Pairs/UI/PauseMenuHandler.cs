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
            SceneManager.LoadScene("Scenes/MainMenu");
        }

        private void levelSelect_clicked()
        {
            Time.timeScale = 1;
            menuManager.levelSelectMenuHandler.GetComponent<LevelSelectMenuHandler>().pairsGame.Board.ClearBoard();
            menuManager.ShowMenu(menuManager.levelSelectMenuHandler.gameObject);
        }

        private void resume_clicked()
        {
            Time.timeScale = 1;
            menuManager.ShowMenu(menuManager.playerHud.gameObject);
        }
    }
}
