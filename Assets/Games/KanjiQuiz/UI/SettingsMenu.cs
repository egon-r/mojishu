using Games.Shared.Util.Menu;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Games.KanjiQuiz.UI
{
    public class SettingsMenu: AnimatedMenu
    {
        private KanjiQuizGame Game;
        public Button BackButton;
        private MenuManager menuManager;
        public Toggle ShowRomajiToggle;
        public Toggle ShowEnglishTranslationsToggle;
        public Slider FontSizeSlider;
        public TMP_Text FontSizeExampleText;

        private void Start()
        {
            Game = KanjiQuizGame.GetCurrentGame();
            menuManager = getMenuManager();
            BackButton.onClick.AddListener(BackButton_clicked);
            ShowRomajiToggle.onValueChanged.AddListener(ShowRomajiToggle_changed);
            ShowEnglishTranslationsToggle.onValueChanged.AddListener(ShowEnglishTranslationsToggle_changed);
            FontSizeSlider.onValueChanged.AddListener(FontSizeSlider_changed);
        }

        private void FontSizeSlider_changed(float arg0)
        {
            FontSizeExampleText.fontSize = arg0;
            Game.SaveFile.questionPanelFontSize = arg0;
        }

        private void ShowEnglishTranslationsToggle_changed(bool arg0)
        {
            Game.SaveFile.showEnglishTranslations = arg0;
        }

        private void ShowRomajiToggle_changed(bool arg0)
        {
            Game.SaveFile.showRomaji = arg0;
        }

        private void BackButton_clicked()
        {
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<LevelSelectMenu>());
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
    }
}