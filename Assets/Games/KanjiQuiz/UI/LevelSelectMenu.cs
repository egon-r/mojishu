using System;
using System.Collections.Generic;
using System.Linq;
using Games.KanjiQuiz.Savegame;
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
        public KanjiQuizGame Game;
        public TMP_Dropdown KanjiSetDropdown;
        private Dictionary<int, KanjiData.KanjiSet> KanjiSetDropdownOptions = new();
        public Button BackButton;
        public Button StartButton;
        public Toggle ShowRomajiToggle;
        public Toggle ShowEnglishTranslationsToggle;

        private void OnEnable()
        {
            var savedata = new KanjiQuizSaveData();
            savedata.ReadFromFile();
            (new KanjiQuizSaveDataReporter(savedata)).PrintReport();
        }

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

            var defaultSelection = KanjiData.KanjiSet.TOP_100_MOST_FREQUENT;
            var defaultSelectionIndex = 0;
            var sortedNames = KanjiData.KanjiSetFriendlyNames
                .ToList().OrderByDescending(kv => kv.Key);
            
            for (var i = 0; i < sortedNames.Count(); i++)
            {
                var kanjiSet = sortedNames.ElementAt(i);

                var kanjiList = KanjiData.getKanjiSet(kanjiSet.Key);
                Debug.Log($"'{kanjiSet.Value}' contains {kanjiList.Count()} entries.");
                if (kanjiList.Count() < 12)
                {
                    Debug.LogError("Not enough kanji in set '" + kanjiSet.Value + "'");
                    continue;
                }

                
                if (kanjiSet.Key == defaultSelection)
                {
                    defaultSelectionIndex = i;
                }
                KanjiSetDropdown.options.Add(new TMP_Dropdown.OptionData(
                    kanjiSet.Value
                ));
                KanjiSetDropdownOptions[i] = kanjiSet.Key;
            }

            KanjiSetDropdown.value = Int32.MaxValue;
            KanjiSetDropdown.value = defaultSelectionIndex;
        }

        private KanjiData.KanjiSet GetSelectedSet()
        {
            return KanjiSetDropdownOptions[KanjiSetDropdown.value];
        }

        private void StartButton_clicked()
        {
            var menuManager = gameObject.GetComponentInParent<MenuManager>();
            Debug.Log(Enum.GetName(typeof(KanjiData.KanjiSet), GetSelectedSet()));
            menuManager.HideCurrentMenu(() =>
            {
                Game.StartRound(
                    new KanjiQuizGameInitData(
                        ShowRomajiToggle.isOn,
                        ShowEnglishTranslationsToggle.isOn,
                        6, GetSelectedSet()
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