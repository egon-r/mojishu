using Games.Shared.Util.Menu;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Games.Pairs.UI
{
    /// <summary>
    /// Contains all functions of the player hud (ui visible during gameplay)
    /// </summary>
    public class PlayerHud : AnimatedMenu
    {
        private MenuManager menuManager;
        public TextMeshProUGUI LevelText;
        public Button Pause;

        // Start is called before the first frame update
        void Start()
        {
            menuManager = gameObject.GetComponentInParent<MenuManager>();
            Pause.onClick.AddListener(pause_clicked);
        }
    
        private void pause_clicked()
        {
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<PauseMenu>(), () =>
            {
                Time.timeScale = 0;
            }, parallel: true);
        }
    }
}
