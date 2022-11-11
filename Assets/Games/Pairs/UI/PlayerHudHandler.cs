using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Games.Pairs.UI
{
    /// <summary>
    /// Contains all functions of the player hud (ui visible during gameplay)
    /// </summary>
    public class PlayerHudHandler : MonoBehaviour
    {
        public TextMeshProUGUI LevelText;
        public PairsMenuManager MenuManager;
        public Button Pause;

        // Start is called before the first frame update
        void Start()
        {
            Pause.onClick.AddListener(pause_clicked);
        }
    
        private void pause_clicked()
        {
            Time.timeScale = 0;
            MenuManager.ShowMenu(MenuManager.pauseMenu.gameObject);
        }
    }
}
