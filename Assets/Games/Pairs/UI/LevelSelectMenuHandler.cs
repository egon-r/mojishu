using System.Collections.Generic;
using Games.Pairs.Savegame;
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
        public Button katakanaButton;
        public Button hiraganaButton;
        public Button mixedButton;
        public Button mainMenuButton;
    
        public PairsMenuManager menuManager;
        public LevelListItem levelListItemPrefab;
        public GameObject levelPanelContainer;
        public PairsGame pairsGame;

        private PairsSaveData pairsSaveData = new PairsSaveData();
        private Dictionary<string, PairsGameInitData> LevelData = new Dictionary<string, PairsGameInitData>();
        private Dictionary<string, LevelListItem> LevelPanels = new Dictionary<string, LevelListItem>();

        // Start is called before the first frame update
        void Start()
        {
            hiraganaButton.onClick.AddListener(hiraganaButton_clicked);
            katakanaButton.onClick.AddListener(katakanaButton_clicked);
            mixedButton.onClick.AddListener(mixedButton_clicked);
            mainMenuButton.onClick.AddListener(mainMenuButton_clicked);
            
            CreateHiraganaLevelItems();
        }

        private void mainMenuButton_clicked()
        {
            SceneManager.LoadScene("Scenes/MainMenu");
        }
        
        private void mixedButton_clicked()
        {
            CreateMixedLevelItems();
        }

        private void katakanaButton_clicked()
        {
            CreateKatakanaLevelItems();
        }

        private void hiraganaButton_clicked()
        {
            CreateHiraganaLevelItems();
        }
        
        private void CreateMixedLevelItems()
        {
            ClearLevelPanelContainer();
            LevelData.Clear();

            var levelCounter = 0;

            levelCounter++;
            var levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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


            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "タ", "Ta" },
                        { "チ", "Ti" },
                        { "ツ", "Tsu" },
                        { "テ", "Te" },
                        { "ト", "To" },
                        { "た", "Ta" },
                        { "ち", "Ti" },
                        { "つ", "Tsu" },
                        { "て", "Te" },
                        { "と", "To" },
                    }
                )
            );
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ダ", "Da" },
                        { "ヂ", "Ji" },
                        { "ヅ", "Du" },
                        { "デ", "De" },
                        { "ド", "Do" },
                        { "だ", "Da" },
                        { "ぢ", "Ji" },
                        { "づ", "Du" },
                        { "で", "De" },
                        { "ど", "Do" },
                    }
                )
            );

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    new Dictionary<string, string>()
                    {
                        { "ハ", "Ha" },
                        { "ヒ", "Hi" },
                        { "フ", "Hu" },
                        { "ヘ", "He" },
                        { "ホ", "Ho" },
                        { "は", "Ha" },
                        { "ひ", "Hi" },
                        { "ふ", "Hu" },
                        { "へ", "He" },
                        { "ほ", "Ho" },
                    }
                )
            );
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Kana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelName = "Final Level";
            var allKatakana = new Dictionary<string, string>();
            foreach (var ldata in LevelData)
            {
                foreach (var pair in ldata.Value.Pairs)
                {
                    allKatakana.Add(pair.Key, pair.Value);
                }
            }
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 7, 4, 7, allKatakana)
            );
            
            ReadLevelHighscores();
        }

        private void CreateKatakanaLevelItems()
        {
            ClearLevelPanelContainer();
            LevelData.Clear();

            var levelCounter = 0;

            levelCounter++;
            var levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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


            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "タ", "Ta" },
                        { "チ", "Ti" },
                        { "ツ", "Tsu" },
                        { "テ", "Te" },
                        { "ト", "To" },
                    }
                )
            );
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ダ", "Da" },
                        { "ヂ", "Ji" },
                        { "ヅ", "Du" },
                        { "デ", "De" },
                        { "ド", "Do" },
                    }
                )
            );

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "ハ", "Ha" },
                        { "ヒ", "Hi" },
                        { "フ", "Hu" },
                        { "ヘ", "He" },
                        { "ホ", "Ho" },
                    }
                )
            );
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelName = "All Katakana";
            var allKatakana = new Dictionary<string, string>();
            foreach (var ldata in LevelData)
            {
                foreach (var pair in ldata.Value.Pairs)
                {
                    allKatakana.Add(pair.Key, pair.Value);
                }
            }
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 6, 4, 3, allKatakana)
            );
            
            ReadLevelHighscores();
        }
        
        private void CreateHiraganaLevelItems()
        {
            ClearLevelPanelContainer();
            LevelData.Clear();

            var levelCounter = 0;

            levelCounter++;
            var levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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


            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "た", "Ta" },
                        { "ち", "Ti" },
                        { "つ", "Tsu" },
                        { "て", "Te" },
                        { "と", "To" },
                    }
                )
            );
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "だ", "Da" },
                        { "ぢ", "Ji" },
                        { "づ", "Du" },
                        { "で", "De" },
                        { "ど", "Do" },
                    }
                )
            );

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 3,
                    new Dictionary<string, string>()
                    {
                        { "は", "Ha" },
                        { "ひ", "Hi" },
                        { "ふ", "Hu" },
                        { "へ", "He" },
                        { "ほ", "Ho" },
                    }
                )
            );
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            LevelPanels[levelName] = createLevel(
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
        
            levelName = "All Hiragana";
            var allHiragana = new Dictionary<string, string>();
            foreach (var ldata in LevelData)
            {
                foreach (var pair in ldata.Value.Pairs)
                {
                    allHiragana.Add(pair.Key, pair.Value);
                }
            }
            LevelPanels[levelName] = createLevel(
                levelName,
                new PairsGameInitData(levelName, 6, 4, 3, allHiragana)
            );
            
            ReadLevelHighscores();
        }

        private LevelListItem createLevel(string levelName, PairsGameInitData gameInitData)
        {
            LevelData[levelName] = gameInitData;

            var levelPanel = Instantiate(levelListItemPrefab, levelPanelContainer.transform);

            levelPanel.LevelNameText.text = levelName;
            foreach (var pair in gameInitData.Pairs)
            {
                levelPanel.AddPairDetail(pair.Key, pair.Value);
            }

            levelPanel.PlayClicked += () =>
            {
                menuManager.ShowMenu(menuManager.playerHud.gameObject);
                pairsGame.Initialize(gameInitData);
            };

            return levelPanel;
        }

        private void ReadLevelHighscores()
        {
            pairsSaveData.ReadFromFile();
            foreach (var ldata in LevelData)
            {
                if (pairsSaveData.LevelHighscores100.ContainsKey(ldata.Key))
                {
                    var highscore100 = pairsSaveData.LevelHighscores100[ldata.Key];
                    LevelPanels[ldata.Key].SetHighscoreText(highscore100 + "%");
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
                Destroy(child.gameObject);
            }
        }
    }
}