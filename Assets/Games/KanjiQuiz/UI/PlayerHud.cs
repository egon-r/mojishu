using System;
using Games.Shared.Data;
using Games.Shared.Util.Menu;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Games.KanjiQuiz.UI
{
    public class PlayerHud : AnimatedMenu
    {
        private MenuManager menuManager;
        public KanjiQuizGame Game;
        public Button PauseButton;
        public TextMeshProUGUI LevelNameText;

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
    }
}
