using UnityEngine;

namespace Games.Pairs.UI
{
    /// <summary>
    /// Manages the visibility of all available menus (children of this) in the pairs game.
    /// </summary>
    public class PairsMenuManager : MonoBehaviour
    {
        public LevelSelectMenuHandler levelSelectMenuHandler;
        public PlayerHudHandler playerHud;
        public PauseMenuHandler pauseMenu;
        public GameFinishedMenuHandler gameFinishedMenu;

        void Start()
        {
            ShowMenu(levelSelectMenuHandler.gameObject);
        }

        public void HideMenu(GameObject menu)
        {
            menu.gameObject.SetActive(false);
        }

        public void ShowMenu(GameObject menu, bool hideOthers = true)
        {
            if (hideOthers)
            {
                HideMenu(levelSelectMenuHandler.gameObject);
                HideMenu(playerHud.gameObject);
                HideMenu(pauseMenu.gameObject);
                HideMenu(gameFinishedMenu.gameObject);
            }
            
            menu.gameObject.SetActive(true);
        }
    }
}