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
        var levelName = "Hiragana 1";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 2, 3,
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


        levelName = "Hiragana 2";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 2, 3,
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
        
        levelName = "Hiragana 2-2";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 2, 3,
                new Dictionary<string, string>()
                {
                    { "が", "Ga" },
                    { "ぎ", "Gi" },
                    { "ぐ", "Gu" },
                    { "げ", "Ge" },
                    { "ご", "Go" },
                    { "ぎゃ", "Gya" },
                    { "ぎゅ", "Gyu" },
                    { "ぎょ", "Gyo" },
                }
            )
        );
        
        levelName = "Hiragana 3";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 2, 3,
                new Dictionary<string, string>()
                {
                    { "", "Sa" },
                    { "", "Shi" },
                    { "", "Su" },
                    { "", "Se" },
                    { "", "So" },
                    
                    { "", "Za" },
                    { "", "Ji" },
                    { "", "Zu" },
                    { "", "Ze" },
                    { "", "Zo" },
                }
            )
        );
        
        // TODO: Hiragana 1-3 (includes all from 1-3)
        
        levelName = "Hiragana 4";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 2, 3,
                new Dictionary<string, string>()
                {
                    { "", "Ta" },
                    { "", "Ti" },
                    { "", "Tu" },
                    { "", "Te" },
                    { "", "To" },
                    
                    { "", "Da" },
                    { "", "Ji" },
                    { "", "Zu" },
                    { "", "De" },
                    { "", "Do" },
                }
            )
        );
        
        levelName = "Hiragana 5";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 3, 3,
                new Dictionary<string, string>()
                {
                    { "", "Na" },
                    { "", "Ni" },
                    { "", "Nu" },
                    { "", "Ne" },
                    { "", "No" },
                    { "", "N" },
                }
            )
        );
        
        levelName = "Hiragana 6";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 2, 3,
                new Dictionary<string, string>()
                {
                    { "", "Ha" },
                    { "", "Hi" },
                    { "", "Hu" },
                    { "", "He" },
                    { "", "Ho" },
                }
            )
        );
        
        levelName = "Hiragana 7";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 2, 3,
                new Dictionary<string, string>()
                {
                    { "", "Ma" },
                    { "", "Mi" },
                    { "", "Mu" },
                    { "", "Me" },
                    { "", "Mo" },
                }
            )
        );
        
        levelName = "Hiragana 8";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 2, 3,
                new Dictionary<string, string>()
                {
                    { "", "Ra" },
                    { "", "Ri" },
                    { "", "Ru" },
                    { "", "Re" },
                    { "", "Ro" },
                }
            )
        );
        
        levelName = "Hiragana 8";
        LevelPanels[levelName] = createLevel(
            levelName,
            new PairsGameInitData(levelName, 4, 2, 3,
                new Dictionary<string, string>()
                {
                    { "", "Ya" },
                    { "", "Wa" },
                    { "", "Yu" },
                    { "", "Yo" },
                    { "", "Wo" },
                }
            )
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
        foreach (var data in LevelData)
        {
            if (pairsSaveData.LevelHighscores100.ContainsKey(data.Key))
            {
                var highscore100 = pairsSaveData.LevelHighscores100[data.Key];
                LevelPanels[data.Key].SetHighscoreText(highscore100 + "%");
                Debug.Log($"{data.Key} score: {highscore100}");
            }
        }
    }
}