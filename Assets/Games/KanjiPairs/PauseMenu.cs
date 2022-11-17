using System.IO.Enumeration;
using Games.Shared.Util.Menu;
using UnityEngine;
using UnityEngine.UI;

namespace Games.KanjiPairs
{
    public class PauseMenu : AnimatedMenu
    {
        public Button ResumeButton;
        private MenuManager menuManager;

        // Start is called before the first frame update
        void Start()
        {
            menuManager = gameObject.GetComponentInParent<MenuManager>();
            ResumeButton.onClick.AddListener(ResumeButton_clicked);
        }

        private void ResumeButton_clicked()
        {
            Time.timeScale = 1;
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<PlayerHud>(), parallel: true);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
