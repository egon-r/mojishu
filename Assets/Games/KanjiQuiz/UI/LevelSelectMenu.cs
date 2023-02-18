using System;
using System.Linq;
using Games.Shared.Data;
using Games.Shared.Util.Menu;
using Scenes.MainMenu;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Games.KanjiQuiz.UI
{
    public class LevelSelectMenu : AnimatedMenu
    {
        private KanjiQuizGame Game;
        public TMP_Dropdown KanjiSetDropdown;
        public Button BackButton;
        public Button SettingsButton;
        public Button StartButton;
        private MenuManager menuManager;

        private void OnEnable()
        {
            Game.SaveFile.ReadFromFile();
        }

        private void Start()
        {            
            Game = KanjiQuizGame.GetCurrentGame();
            menuManager = getMenuManager();
            InitializeKanjiSetDropdown();
            BackButton.onClick.AddListener(BackButton_clicked);
            StartButton.onClick.AddListener(StartButton_clicked);
            SettingsButton.onClick.AddListener(SettingsButton_clicked);
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
        
        private void SettingsButton_clicked()
        {
            menuManager.HideCurrentMenu(() =>
            {
                menuManager.ShowMenu(menuManager.GetMenuByType<SettingsMenu>());
            });
        }

        private void InitializeKanjiSetDropdown()
        {
            KanjiSetDropdown.options.Clear();

            foreach (var kanjiDataset in KanjiData.Datasets)
            {
                Debug.Log($"'{kanjiDataset.Key}' contains {kanjiDataset.Value.Count()} entries.");
                KanjiSetDropdown.options.Add(new TMP_Dropdown.OptionData(kanjiDataset.Key));
            }
            KanjiSetDropdown.value = Int32.MaxValue;
            KanjiSetDropdown.value = 0;
        }

        private void StartButton_clicked()
        {
            Debug.Log($"Selected Set: {KanjiData.Datasets.ElementAt(KanjiSetDropdown.value).Key}");
            menuManager.HideCurrentMenu(() =>
            {
                Game.StartRound(
                    new KanjiQuizGameInitData(
                        KanjiData.Datasets.ElementAt(KanjiSetDropdown.value).Key,
                        6
                    )
                );
                menuManager.ShowMenu(menuManager.GetMenuByType<PlayerHud>());
            });
        }

        private void BackButton_clicked()
        {
            MainMenuManager.EntryPoint = MainMenuManager.MainMenuEntryPoint.PLAY;
            SceneManager.LoadScene("Scenes/MainMenu");
        }
    }
}