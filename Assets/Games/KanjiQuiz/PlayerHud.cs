using Games.Shared.Util.Menu;
using UnityEngine;
using UnityEngine.UI;

namespace Games.KanjiPairs
{
    public class PlayerHud : AnimatedMenu
    {
        private MenuManager menuManager;
        public Button PauseButton;
        
        // Start is called before the first frame update
        void Start()
        {
            menuManager = gameObject.GetComponentInParent<MenuManager>();
            PauseButton.onClick.AddListener(PauseButton_clicked);
        }

        private void PauseButton_clicked()
        {
            PauseButton.enabled = false;
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<PauseMenu>(), () =>
            {
                PauseButton.enabled = true;
                Time.timeScale = 0;
            }, parallel: true);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
