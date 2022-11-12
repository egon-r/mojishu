using System.Collections.Generic;
using System.Linq;
using Games.Pairs.Savegame;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Games.Pairs.UI
{
    /// <summary>
    /// Contains all functions of the level select UI
    /// </summary>
    public class LevelSelectMenuHandler : MonoBehaviour
    {
        public Sprite buttonHighlightSprite;
        public Sprite buttonDefaultSprite;
        public Button katakanaButton;
        public Button hiraganaButton;
        public Button mixedButton;

        public Button mainMenuButton;

        public PairsMenuManager menuManager;
        public LevelListItem levelListItemPrefab;
        public GameObject levelPanelContainer;
        public PairsGame pairsGame;

        private PairsSaveData pairsSaveData = new PairsSaveData();
        private Dictionary<string, LevelListItem> kanaLevelPanels = new Dictionary<string, LevelListItem>();
        private Dictionary<string, LevelListItem> hiraganaLevelPanels = new Dictionary<string, LevelListItem>();
        private Dictionary<string, LevelListItem> katakanaLevelPanels = new Dictionary<string, LevelListItem>();
        private LinkedList<LevelListItem> levelLinks = new LinkedList<LevelListItem>();
        private LevelListItem currentLevelListItem;
        private LinkedListNode<LevelListItem> currentLevelLinksNode;

        // Start is called before the first frame update
        void Start()
        {
            hiraganaButton.onClick.AddListener(hiraganaButton_clicked);
            katakanaButton.onClick.AddListener(katakanaButton_clicked);
            mixedButton.onClick.AddListener(mixedButton_clicked);
            mainMenuButton.onClick.AddListener(mainMenuButton_clicked);

            // order matters
            CreateHiraganaLevelItems();
            CreateKatakanaLevelItems();
            CreateMixedLevelItems();

            // select first page
            hiraganaButton_clicked();
            ReadLevelHighscores();
        }

        [CanBeNull]
        public LevelListItem GetNextLevel(string levelName)
        {
            LevelListItem current = null;
            if (hiraganaLevelPanels.ContainsKey(levelName))
            {
                current = hiraganaLevelPanels[levelName];
            }
            else if (katakanaLevelPanels.ContainsKey(levelName))
            {
                current = katakanaLevelPanels[levelName];
            }
            else if (kanaLevelPanels.ContainsKey(levelName))
            {
                current = kanaLevelPanels[levelName];
            }
            else
            {
                return null;
            }

            return levelLinks.Find(current)?.Next?.Value;
        }

        private void mainMenuButton_clicked()
        {
            SceneManager.LoadScene("Scenes/MainMenu");
        }

        private void highlightLevelTypeButton(Button button)
        {
            hiraganaButton.GetComponent<Image>().sprite = buttonDefaultSprite;
            katakanaButton.GetComponent<Image>().sprite = buttonDefaultSprite;
            mixedButton.GetComponent<Image>().sprite = buttonDefaultSprite;
            button.GetComponent<Image>().sprite = buttonHighlightSprite;
        }

        private void mixedButton_clicked()
        {
            highlightLevelTypeButton(mixedButton);
            ClearLevelPanelContainer();
            foreach (var kv in kanaLevelPanels)
            {
                kv.Value.gameObject.SetActive(true);
            }
        }

        private void katakanaButton_clicked()
        {
            highlightLevelTypeButton(katakanaButton);
            ClearLevelPanelContainer();
            foreach (var kv in katakanaLevelPanels)
            {
                kv.Value.gameObject.SetActive(true);
            }
        }

        private void hiraganaButton_clicked()
        {
            highlightLevelTypeButton(hiraganaButton);
            ClearLevelPanelContainer();
            foreach (var kv in hiraganaLevelPanels)
            {
                kv.Value.gameObject.SetActive(true);
            }
        }

        public void PlayLevel(PairsGameInitData gameInitData)
        {
            menuManager.playerHud.LevelText.text = gameInitData.levelName;
            menuManager.ShowMenu(menuManager.playerHud.gameObject);
            pairsGame.Initialize(gameInitData);
        }

        private LevelListItem createLevelListItem(string levelName, PairsGameInitData gameInitData)
        {
            var levelPanel = Instantiate(levelListItemPrefab, levelPanelContainer.transform);

            levelPanel.LevelNameText.text = levelName;
            levelPanel.GameInitData = gameInitData;
            levelPanel.SetHighscore(0);
            foreach (var pair in gameInitData.Pairs)
            {
                levelPanel.AddPairDetail(pair.Key, pair.Value);
            }

            levelPanel.PlayClicked += () => { PlayLevel(gameInitData); };

            return levelPanel;
        }

        private void ReadLevelHighscores()
        {
            pairsSaveData.ReadFromFile();
            foreach (var ldata in hiraganaLevelPanels)
            {
                if (pairsSaveData.LevelHighscores100.ContainsKey(ldata.Key))
                {
                    var highscore100 = pairsSaveData.LevelHighscores100[ldata.Key];
                    hiraganaLevelPanels[ldata.Key].SetHighscore(highscore100);
                }
            }

            foreach (var ldata in katakanaLevelPanels)
            {
                if (pairsSaveData.LevelHighscores100.ContainsKey(ldata.Key))
                {
                    var highscore100 = pairsSaveData.LevelHighscores100[ldata.Key];
                    katakanaLevelPanels[ldata.Key].SetHighscore(highscore100);
                }
            }

            foreach (var ldata in kanaLevelPanels)
            {
                if (pairsSaveData.LevelHighscores100.ContainsKey(ldata.Key))
                {
                    var highscore100 = pairsSaveData.LevelHighscores100[ldata.Key];
                    kanaLevelPanels[ldata.Key].SetHighscore(highscore100);
                }
            }
        }

        private void OnEnable()
        {
            // triggered by setActive
            ReadLevelHighscores();
        }

        private void ClearLevelPanelContainer()
        {
            foreach (Transform child in levelPanelContainer.transform)
            {
                child.gameObject.SetActive(false);
            }
        }

        private void CreateMixedLevelItems()
        {
            var levelCounter = 0;

            levelCounter++;
            var levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ア", "A" },
                        { "イ", "I" },
                        { "ウ", "U" },
                        { "エ", "E" },
                        { "オ", "O" },
                        { "あ", "A" },
                        { "い", "I" },
                        { "う", "U" },
                        { "え", "E" },
                        { "お", "O" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "カ", "Ka" },
                        { "キ", "Ki" },
                        { "ク", "Ku" },
                        { "ケ", "Ke" },
                        { "コ", "Ko" },
                        { "か", "Ka" },
                        { "き", "Ki" },
                        { "く", "Ku" },
                        { "け", "Ke" },
                        { "こ", "Ko" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ガ", "Ga" },
                        { "ギ", "Gi" },
                        { "グ", "Gu" },
                        { "ゲ", "Ge" },
                        { "ゴ", "Go" },
                        { "が", "Ga" },
                        { "ぎ", "Gi" },
                        { "ぐ", "Gu" },
                        { "げ", "Ge" },
                        { "ご", "Go" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "サ", "Sa" },
                        { "シ", "Shi" },
                        { "ス", "Su" },
                        { "セ", "Se" },
                        { "ソ", "So" },
                        { "さ", "Sa" },
                        { "し", "Shi" },
                        { "す", "Su" },
                        { "せ", "Se" },
                        { "そ", "So" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ザ", "Za" },
                        { "ジ", "Ji" },
                        { "ズ", "Zu" },
                        { "ゼ", "Ze" },
                        { "ゾ", "Zo" },
                        { "ざ", "Za" },
                        { "じ", "Ji" },
                        { "ず", "Zu" },
                        { "ぜ", "Ze" },
                        { "ぞ", "Zo" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "タ", "Ta" },
                        { "チ", "Chi" },
                        { "ツ", "Tsu" },
                        { "テ", "Te" },
                        { "ト", "To" },
                        { "た", "Ta" },
                        { "ち", "Chi" },
                        { "つ", "Tsu" },
                        { "て", "Te" },
                        { "と", "To" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ダ", "Da" },
                        { "ヂ", "Ji" },
                        { "ヅ", "Zu" },
                        { "デ", "De" },
                        { "ド", "Do" },
                        { "だ", "Da" },
                        { "ぢ", "Ji" },
                        { "づ", "Zu" },
                        { "で", "De" },
                        { "ど", "Do" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ナ", "Na" },
                        { "ニ", "Ni" },
                        { "ヌ", "Nu" },
                        { "ネ", "Ne" },
                        { "ノ", "No" },
                        { "ン", "N" },
                        { "な", "Na" },
                        { "に", "Ni" },
                        { "ぬ", "Nu" },
                        { "ね", "Ne" },
                        { "の", "No" },
                        { "ん", "N" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ハ", "Ha" },
                        { "ヒ", "Hi" },
                        { "フ", "Fu" },
                        { "ヘ", "He" },
                        { "ホ", "Ho" },
                        { "は", "Ha" },
                        { "ひ", "Hi" },
                        { "ふ", "Fu" },
                        { "へ", "He" },
                        { "ほ", "Ho" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "バ", "Ba" },
                        { "ビ", "Bi" },
                        { "ブ", "Bu" },
                        { "ベ", "Be" },
                        { "ボ", "Bo" },
                        { "ば", "Ba" },
                        { "び", "Bi" },
                        { "ぶ", "Bu" },
                        { "べ", "Be" },
                        { "ぼ", "Bo" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "パ", "Pa" },
                        { "ピ", "Pi" },
                        { "プ", "Pu" },
                        { "ペ", "Pe" },
                        { "ポ", "Po" },
                        { "ぱ", "Pa" },
                        { "ぴ", "Pi" },
                        { "ぷ", "Pu" },
                        { "ぺ", "Pe" },
                        { "ぽ", "Po" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "マ", "Ma" },
                        { "ミ", "Mi" },
                        { "ム", "Mu" },
                        { "メ", "Me" },
                        { "モ", "Mo" },
                        { "ま", "Ma" },
                        { "み", "Mi" },
                        { "む", "Mu" },
                        { "め", "Me" },
                        { "も", "Mo" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ラ", "Ra" },
                        { "リ", "Ri" },
                        { "ル", "Ru" },
                        { "レ", "Re" },
                        { "ロ", "Ro" },
                        { "ら", "Ra" },
                        { "り", "Ri" },
                        { "る", "Ru" },
                        { "れ", "Re" },
                        { "ろ", "Ro" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ヤ", "Ya" },
                        { "ユ", "Yu" },
                        { "ヨ", "Yo" },
                        { "ワ", "Wa" },
                        { "ヲ", "Wo" },
                        { "や", "Ya" },
                        { "ゆ", "Yu" },
                        { "よ", "Yo" },
                        { "わ", "Wa" },
                        { "を", "Wo" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ギャ", "Gya" },
                        { "ギュ", "Gyu" },
                        { "ギョ", "Gyo" },
                        { "ジャ", "Ja" },
                        { "ジュ", "Ju" },
                        { "ジョ", "Jo" },
                        { "ヂャ", "Ja" },
                        { "ヂュ", "Ju" },
                        { "ヂョ", "Jo" },
                        { "ぎゃ", "Gya" },
                        { "ぎゅ", "Gyu" },
                        { "ぎょ", "Gyo" },
                        { "じゃ", "Ja" },
                        { "じゅ", "Ju" },
                        { "じょ", "Jo" },
                        { "ぢゃ", "Ja" },
                        { "ぢゅ", "Ju" },
                        { "ぢょ", "Jo" },
                    }
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelName = "Final Level";
            var allKatakana = new Dictionary<string, string>();
            foreach (var ldata in kanaLevelPanels)
            {
                Debug.Log(ldata.Key + " -> " + ldata.Value.GameInitData);
                foreach (var pair in ldata.Value.GameInitData.Pairs)
                {
                    allKatakana.Add(pair.Key, pair.Value);
                }
            }

            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 7, 4, 7, allKatakana)
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
        }

        private void CreateKatakanaLevelItems()
        {
            var levelCounter = 0;

            levelCounter++;
            var levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ア", "A" },
                        { "イ", "I" },
                        { "ウ", "U" },
                        { "エ", "E" },
                        { "オ", "O" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "カ", "Ka" },
                        { "キ", "Ki" },
                        { "ク", "Ku" },
                        { "ケ", "Ke" },
                        { "コ", "Ko" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ガ", "Ga" },
                        { "ギ", "Gi" },
                        { "グ", "Gu" },
                        { "ゲ", "Ge" },
                        { "ゴ", "Go" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "サ", "Sa" },
                        { "シ", "Shi" },
                        { "ス", "Su" },
                        { "セ", "Se" },
                        { "ソ", "So" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ザ", "Za" },
                        { "ジ", "Ji" },
                        { "ズ", "Zu" },
                        { "ゼ", "Ze" },
                        { "ゾ", "Zo" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "タ", "Ta" },
                        { "チ", "Chi" },
                        { "ツ", "Tsu" },
                        { "テ", "Te" },
                        { "ト", "To" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ダ", "Da" },
                        { "ヂ", "Ji" },
                        { "ヅ", "Zu" },
                        { "デ", "De" },
                        { "ド", "Do" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 3, 3,
                    new Dictionary<string, string>()
                    {
                        { "ナ", "Na" },
                        { "ニ", "Ni" },
                        { "ヌ", "Nu" },
                        { "ネ", "Ne" },
                        { "ノ", "No" },
                        { "ン", "N" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ハ", "Ha" },
                        { "ヒ", "Hi" },
                        { "フ", "Fu" },
                        { "ヘ", "He" },
                        { "ホ", "Ho" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "バ", "Ba" },
                        { "ビ", "Bi" },
                        { "ブ", "Bu" },
                        { "ベ", "Be" },
                        { "ボ", "Bo" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "パ", "Pa" },
                        { "ピ", "Pi" },
                        { "プ", "Pu" },
                        { "ペ", "Pe" },
                        { "ポ", "Po" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "マ", "Ma" },
                        { "ミ", "Mi" },
                        { "ム", "Mu" },
                        { "メ", "Me" },
                        { "モ", "Mo" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ラ", "Ra" },
                        { "リ", "Ri" },
                        { "ル", "Ru" },
                        { "レ", "Re" },
                        { "ロ", "Ro" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ヤ", "Ya" },
                        { "ユ", "Yu" },
                        { "ヨ", "Yo" },
                        { "ワ", "Wa" },
                        { "ヲ", "Wo" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 6, 3, 3,
                    new Dictionary<string, string>()
                    {
                        { "ギャ", "Gya" },
                        { "ギュ", "Gyu" },
                        { "ギョ", "Gyo" },
                        { "ジャ", "Ja" },
                        { "ジュ", "Ju" },
                        { "ジョ", "Jo" },
                        { "ヂャ", "Ja" },
                        { "ヂュ", "Ju" },
                        { "ヂョ", "Jo" },
                    }
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelName = "All Katakana";
            var allKatakana = new Dictionary<string, string>();
            foreach (var ldata in katakanaLevelPanels)
            {
                foreach (var pair in ldata.Value.GameInitData.Pairs)
                {
                    allKatakana.Add(pair.Key, pair.Value);
                }
            }

            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 6, 4, 3, allKatakana)
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
        }

        private void CreateHiraganaLevelItems()
        {
            var levelCounter = 0;

            levelCounter++;
            var levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "あ", "A" },
                        { "い", "I" },
                        { "う", "U" },
                        { "え", "E" },
                        { "お", "O" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddFirst(currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "か", "Ka" },
                        { "き", "Ki" },
                        { "く", "Ku" },
                        { "け", "Ke" },
                        { "こ", "Ko" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "が", "Ga" },
                        { "ぎ", "Gi" },
                        { "ぐ", "Gu" },
                        { "げ", "Ge" },
                        { "ご", "Go" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "さ", "Sa" },
                        { "し", "Shi" },
                        { "す", "Su" },
                        { "せ", "Se" },
                        { "そ", "So" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ざ", "Za" },
                        { "じ", "Ji" },
                        { "ず", "Zu" },
                        { "ぜ", "Ze" },
                        { "ぞ", "Zo" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "た", "Ta" },
                        { "ち", "Chi" },
                        { "つ", "Tsu" },
                        { "て", "Te" },
                        { "と", "To" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "だ", "Da" },
                        { "ぢ", "Ji" },
                        { "づ", "Zu" },
                        { "で", "De" },
                        { "ど", "Do" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 3, 3,
                    new Dictionary<string, string>()
                    {
                        { "な", "Na" },
                        { "に", "Ni" },
                        { "ぬ", "Nu" },
                        { "ね", "Ne" },
                        { "の", "No" },
                        { "ん", "N" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "は", "Ha" },
                        { "ひ", "Hi" },
                        { "ふ", "Fu" },
                        { "へ", "He" },
                        { "ほ", "Ho" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ば", "Ba" },
                        { "び", "Bi" },
                        { "ぶ", "Bu" },
                        { "べ", "Be" },
                        { "ぼ", "Bo" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ぱ", "Pa" },
                        { "ぴ", "Pi" },
                        { "ぷ", "Pu" },
                        { "ぺ", "Pe" },
                        { "ぽ", "Po" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ま", "Ma" },
                        { "み", "Mi" },
                        { "む", "Mu" },
                        { "め", "Me" },
                        { "も", "Mo" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ら", "Ra" },
                        { "り", "Ri" },
                        { "る", "Ru" },
                        { "れ", "Re" },
                        { "ろ", "Ro" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "や", "Ya" },
                        { "ゆ", "Yu" },
                        { "よ", "Yo" },
                        { "わ", "Wa" },
                        { "を", "Wo" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 6, 3, 3,
                    new Dictionary<string, string>()
                    {
                        { "ぎゃ", "Gya" },
                        { "ぎゅ", "Gyu" },
                        { "ぎょ", "Gyo" },
                        { "じゃ", "Ja" },
                        { "じゅ", "Ju" },
                        { "じょ", "Jo" },
                        { "ぢゃ", "Ja" },
                        { "ぢゅ", "Ju" },
                        { "ぢょ", "Jo" },
                    }
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelName = "All Hiragana";
            var allHiragana = new Dictionary<string, string>();
            foreach (var ldata in hiraganaLevelPanels)
            {
                foreach (var pair in ldata.Value.GameInitData.Pairs)
                {
                    allHiragana.Add(pair.Key, pair.Value);
                }
            }

            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 6, 4, 3, allHiragana)
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
        }
    }
}