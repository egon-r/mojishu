using System.Collections.Generic;
using System.Linq;
using Games.Pairs.Savegame;
using Games.Shared.Data;
using Games.Shared.Util.Menu;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Games.Pairs.UI
{
    /// <summary>
    /// Contains all functions of the level select UI
    /// </summary>
    public class LevelSelectMenu : AnimatedMenu
    {
        private MenuManager menuManager;
        public Sprite buttonHighlightSprite;
        public Sprite buttonDefaultSprite;
        public Button katakanaButton;
        public Button hiraganaButton;
        public Button mixedButton;

        public Button mainMenuButton;

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
            menuManager = gameObject.GetComponentInParent<MenuManager>();

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
            var playerHudMenu = menuManager.GetMenuByType<PlayerHud>(hud =>
            {
                hud.LevelText.text = gameInitData.levelName;
            });
            pairsGame.Initialize(gameInitData);
            menuManager.HideCurrentAndShow(playerHudMenu, parallel: true);
        }

        private LevelListItem createLevelListItem(string levelName, PairsGameInitData gameInitData)
        {
            var levelPanel = Instantiate(levelListItemPrefab, levelPanelContainer.transform);

            levelPanel.LevelNameText.text = levelName;
            levelPanel.GameInitData = gameInitData;
            levelPanel.SetHighscore(0);
            foreach (var pair in gameInitData.Pairs)
            {
                levelPanel.AddPairDetail(pair.Key, pair.Value.Latin);
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
                    KanaDictionary.GetKanaBy(KanaRow.VOWEL_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.Y_ROW, KanaRow.W_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.K_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.K_ROW, KanaRow.K_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.G_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.G_ROW, KanaRow.G_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.S_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.S_ROW, KanaRow.S_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.Z_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.Z_ROW, KanaRow.Z_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.T_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.T_ROW, KanaRow.T_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.D_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.D_ROW, KanaRow.D_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.N_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.N_ROW, KanaRow.N_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.H_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.H_ROW, KanaRow.H_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.B_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.B_ROW, KanaRow.B_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.P_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.P_ROW, KanaRow.P_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.M_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.M_ROW, KanaRow.M_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.R_ROW)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaRow.R_ROW, KanaRow.R_ROW_DIAGRAPH)
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Kana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(
                        KanaRow.K_ROW_DIAGRAPH,
                        KanaRow.S_ROW_DIAGRAPH,
                        KanaRow.T_ROW_DIAGRAPH,
                        KanaRow.N_ROW_DIAGRAPH,
                        KanaRow.H_ROW_DIAGRAPH,
                        KanaRow.M_ROW_DIAGRAPH,
                        KanaRow.R_ROW_DIAGRAPH,
                        KanaRow.G_ROW_DIAGRAPH,
                        KanaRow.Z_ROW_DIAGRAPH,
                        KanaRow.D_ROW_DIAGRAPH,
                        KanaRow.B_ROW_DIAGRAPH,
                        KanaRow.P_ROW_DIAGRAPH
                    )
                )
            );
            kanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelName = "Final Level";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 7, 4, 7, KanaDictionary.AllKana)
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
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.VOWEL_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.Y_ROW, KanaRow.W_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.K_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.K_ROW, KanaRow.K_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.G_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.G_ROW, KanaRow.G_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.S_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.S_ROW, KanaRow.S_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.Z_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.Z_ROW, KanaRow.Z_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.T_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.T_ROW, KanaRow.T_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.D_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.D_ROW, KanaRow.D_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 3, 3,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.N_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.N_ROW, KanaRow.N_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.H_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.H_ROW, KanaRow.H_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.B_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.B_ROW, KanaRow.B_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.P_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.P_ROW, KanaRow.P_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.M_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.M_ROW, KanaRow.M_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.R_ROW)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA, KanaRow.R_ROW, KanaRow.R_ROW_DIAGRAPH)
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Katakana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 6, 3, 6,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA,
                        KanaRow.K_ROW_DIAGRAPH,
                        KanaRow.S_ROW_DIAGRAPH,
                        KanaRow.T_ROW_DIAGRAPH,
                        KanaRow.N_ROW_DIAGRAPH,
                        KanaRow.H_ROW_DIAGRAPH,
                        KanaRow.M_ROW_DIAGRAPH,
                        KanaRow.R_ROW_DIAGRAPH,
                        KanaRow.G_ROW_DIAGRAPH,
                        KanaRow.Z_ROW_DIAGRAPH,
                        KanaRow.D_ROW_DIAGRAPH,
                        KanaRow.B_ROW_DIAGRAPH,
                        KanaRow.P_ROW_DIAGRAPH
                    )
                )
            );
            katakanaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelName = "All Katakana";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 6, 4, 6, KanaDictionary.GetKanaBy(KanaType.KATAKANA))
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
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.VOWEL_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddFirst(currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.Y_ROW, KanaRow.W_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.K_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.K_ROW, KanaRow.K_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.G_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.G_ROW, KanaRow.G_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.S_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.S_ROW, KanaRow.S_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.Z_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.Z_ROW, KanaRow.Z_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.T_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.T_ROW, KanaRow.T_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.D_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.D_ROW, KanaRow.D_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 3, 3,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.N_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.N_ROW, KanaRow.N_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.H_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.H_ROW, KanaRow.H_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.B_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.B_ROW, KanaRow.B_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.P_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.P_ROW, KanaRow.P_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.M_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.M_ROW, KanaRow.M_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 5, 2, 4,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.R_ROW)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
            
            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 4, 4, 5,
                    KanaDictionary.GetKanaBy(KanaType.HIRAGANA, KanaRow.R_ROW, KanaRow.R_ROW_DIAGRAPH)
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelCounter++;
            levelName = $"Hiragana {levelCounter}";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 6, 3, 5,
                    KanaDictionary.GetKanaBy(KanaType.KATAKANA,
                        KanaRow.K_ROW_DIAGRAPH,
                        KanaRow.S_ROW_DIAGRAPH,
                        KanaRow.T_ROW_DIAGRAPH,
                        KanaRow.N_ROW_DIAGRAPH,
                        KanaRow.H_ROW_DIAGRAPH,
                        KanaRow.M_ROW_DIAGRAPH,
                        KanaRow.R_ROW_DIAGRAPH,
                        KanaRow.G_ROW_DIAGRAPH,
                        KanaRow.Z_ROW_DIAGRAPH,
                        KanaRow.D_ROW_DIAGRAPH,
                        KanaRow.B_ROW_DIAGRAPH,
                        KanaRow.P_ROW_DIAGRAPH
                    )
                )
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);

            levelName = "All Hiragana";
            currentLevelListItem = createLevelListItem(
                levelName,
                new PairsGameInitData(levelName, 6, 4, 5, KanaDictionary.GetKanaBy(KanaType.HIRAGANA))
            );
            hiraganaLevelPanels[levelName] = currentLevelListItem;
            currentLevelLinksNode = levelLinks.AddAfter(currentLevelLinksNode, currentLevelListItem);
        }
    }
}