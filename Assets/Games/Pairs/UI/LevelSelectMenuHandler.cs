using System;
using System.Collections;
using System.Collections.Generic;
using Games.Pairs;
using Games.Pairs.Savegame;
using Games.Pairs.UI;
using UnityEngine;

public class LevelSelectMenuHandler : MonoBehaviour
{
    public PairsMenuManager menuManager;
    public LevelPanel levelPanelPrefab;
    public GameObject levelPanelContainer;
    public PairsGame pairsGame;
    private PairsSaveData pairsSaveData = new PairsSaveData();

    private Dictionary<string, PairsGameInitData> LevelData = new Dictionary<string, PairsGameInitData>();
    private Dictionary<string, LevelPanel> LevelPanels = new Dictionary<string, LevelPanel>();

    // Start is called before the first frame update
    void Start()
    {
        InitializeLevels();
        
        // trigger reading highscores
        OnEnable();
    }

    private void InitializeLevels()
    {
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
    }

    private LevelPanel createLevel(string levelName, PairsGameInitData gameInitData)
    {
        LevelData[levelName] = gameInitData;

        var levelPanel = Instantiate(levelPanelPrefab, levelPanelContainer.transform);

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

    private void OnEnable()
    {
        pairsSaveData.ReadFromFile();
        foreach (var ldata in LevelData)
        {
            if (pairsSaveData.LevelHighscores100.ContainsKey(ldata.Key))
            {
                var highscore100 = pairsSaveData.LevelHighscores100[ldata.Key];
                LevelPanels[ldata.Key].SetHighscoreText(highscore100 + "%");
                Debug.Log($"{ldata.Key} score: {highscore100}");
            }
        }
    }
}