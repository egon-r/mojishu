using System;
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
        public Button BackButton;
        public Button StartButton;

        private void Start()
        {
            InitializeKanjiSetDropdown();
            BackButton.onClick.AddListener(BackButton_clicked);
            StartButton.onClick.AddListener(StartButton_clicked);
        }

        private void Update()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    BackButton_clicked();
                }
            }
        }
        
        private void InitializeKanjiSetDropdown()
        {
            KanjiSetDropdown.options.Clear();
            foreach (var set in (KanjiData.KanjiSet[])Enum.GetValues(typeof(KanjiData.KanjiSet)))
            {
                KanjiSetDropdown.options.Add(new TMP_Dropdown.OptionData(
                    Enum.GetName(typeof(KanjiData.KanjiSet), set)
                ));
            }
            KanjiSetDropdown.value = (int)KanjiData.KanjiSet.TOP_100_MOST_FREQUENT;
        }

        private void StartButton_clicked()
        {
            var menuManager = gameObject.GetComponentInParent<MenuManager>();
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<PlayerHud>(), () =>
            {
                Debug.Log(Enum.GetName(typeof(KanjiData.KanjiSet), KanjiSetDropdown.value));
                Game.StartGame(
                    new KanjiQuizGameInitData(6, (KanjiData.KanjiSet)KanjiSetDropdown.value)
                );
            });
        }

        private void BackButton_clicked()
        {
            MainMenuManager.EntryPoint = MainMenuManager.MainMenuEntryPoint.PLAY;
            SceneManager.LoadScene("Scenes/MainMenu");
        }
    }
}
