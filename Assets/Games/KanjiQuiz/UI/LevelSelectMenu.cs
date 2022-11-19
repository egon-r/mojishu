using System;
using System.Linq;
using Games.Pairs.UI;
using Games.Shared.Data;
using Games.Shared.Util.Menu;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Games.KanjiQuiz.UI
{
    public class LevelSelectMenu : AnimatedMenu
    {
        public KanjiQuizGame Game;
        public TMP_Dropdown KanjiSetDropdown;
        public Button MainMenuButton;
        public Button StartButton;

        private void Start()
        {
            InitializeKanjiSetDropdown();
            MainMenuButton.onClick.AddListener(MainMenuButton_clicked);
            StartButton.onClick.AddListener(StartButton_clicked);
        }

        private void InitializeKanjiSetDropdown()
        {
            KanjiSetDropdown.options.Clear();
            foreach (var set in (KanjiSet[])Enum.GetValues(typeof(KanjiSet)))
            {
                KanjiSetDropdown.options.Add(new TMP_Dropdown.OptionData(
                    Enum.GetName(typeof(KanjiSet), set)
                ));
            }
            KanjiSetDropdown.value = (int)KanjiSet.TOP_100_MOST_FREQUENT;
        }

        private void StartButton_clicked()
        {
            var menuManager = gameObject.GetComponentInParent<MenuManager>();
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<PlayerHud>(), () =>
            {
                Debug.Log(Enum.GetName(typeof(KanjiSet), KanjiSetDropdown.value));
                Game.StartGame(
                    new KanjiQuizGameInitData(6, (KanjiSet)KanjiSetDropdown.value)
                );
            });
        }

        private void MainMenuButton_clicked()
        {
            SceneManager.LoadScene("Scenes/MainMenu");
        }
    }
}
