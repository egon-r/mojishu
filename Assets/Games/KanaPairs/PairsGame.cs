using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Games.Pairs.Savegame;
using Games.Pairs.UI;
using Games.Shared.Data;
using Games.Shared.Util.Menu;
using UnityEngine;
using Random = System.Random;

namespace Games.Pairs
{
    public class PairsGame : MonoBehaviour
    {
        public PairsBoard Board;

        public MenuManager menuManager;
        private PairsSaveData saveData = new PairsSaveData();
        private float initialBoardRevealDuration = 3;
        private float revealDuration = 1.5f;
        private bool ignoreClickEvents = false;
        private PairsCard firstCardRevealed = null;
        private PairsCard secondCardRevealed = null;
        private int matches = 0;
        private int attempts = 0;
        private Dictionary<string, KanaInfo> pairsDict;
        private List<PairsCard> matchedCards = new List<PairsCard>();
        private string levelName = "unknown_level";

        public void Initialize(PairsGameInitData pairsGameInitData)
        {
            Debug.Log($"Initializing '{pairsGameInitData.levelName}'...");
            menuManager.GetMenuByType<LevelSelectMenu>(menu =>
            {
                Debug.Log($"Next Level: '{menu.GetNextLevel(pairsGameInitData.levelName)?.GameInitData.levelName}'");
            });

            if ((pairsGameInitData.boardCols * pairsGameInitData.boardRows) % 2 != 0)
            {
                throw new Exception("Invalid board size, number of cards is not even!");
            }

            // set variables
            initialBoardRevealDuration = pairsGameInitData.initialBoardRevealDuration;
            Board.boardCols = pairsGameInitData.boardCols;
            Board.boardRows = pairsGameInitData.boardRows;
            pairsDict = pairsGameInitData.Pairs;
            levelName = pairsGameInitData.levelName;
            matchedCards.Clear();
            matches = 0;
            attempts = 0;

            // check if enough pairs are available
            var minPairCount = (Board.boardRows * Board.boardCols) / 2;
            if (pairsGameInitData.Pairs.Count < minPairCount)
            {
                throw new Exception("Not enough pairs to initialize board without duplicates!");
            }

            // generate board data
            var boardData = new string[Board.boardRows, Board.boardCols];
            var rng = new Random();
            var allPairs = pairsGameInitData.Pairs.ToList();
            var pairItems = new List<string>();

            for (int i = 0; i < minPairCount; i++)
            {
                var rndPair = allPairs[rng.Next(allPairs.Count)];
                pairItems.Add(rndPair.Key);
                pairItems.Add(rndPair.Value.Latin);
                allPairs.Remove(rndPair);
            }

            for (int row = 0; row < Board.boardRows; row++)
            {
                for (int col = 0; col < Board.boardCols; col++)
                {
                    var rndItem = pairItems[rng.Next(pairItems.Count)];
                    boardData[row, col] = rndItem;
                    pairItems.Remove(rndItem);
                }
            }

            Board.Initialize(boardData);

            // bind click
            Board.CardClicked += BoardOnCardClicked;
        }

        public void AsyncInitialBoardReveal(float delayS = 0.0f)
        {
            StopCoroutine(InitialBoardReveal(delayS));
            StartCoroutine(InitialBoardReveal(delayS));
        }
        
        private IEnumerator InitialBoardReveal(float delayS = 0.0f)
        {
            if (initialBoardRevealDuration <= 0)
            {
                yield break;
            }
            
            ignoreClickEvents = true;

            yield return new WaitForSeconds(delayS);
            
            foreach (var card in Board.GetCards())
            {
                card.Reveal();
            }

            yield return new WaitForSeconds(initialBoardRevealDuration);

            foreach (var card in Board.GetCards())
            {
                card.Conceal();
            }

            ignoreClickEvents = false;
        }

        private void GameFinished()
        {
            saveData.ReadFromFile();

            // calc score
            int score = (matches * 10) - ((attempts - matches) * 3);
            int maxScore = matches * 10;
            if (score < 0)
            {
                score = 0;
            }

            int score100 = (int)(((float)score / maxScore) * 100.0f);
            Debug.Log($"Game Finished! Guesses: {attempts}, Matches: {matches}");
            Debug.Log($"Score: {score}/{maxScore}");
            Debug.Log($"Score: {score100}%");

            // save it
            if (saveData.LevelHighscores100.ContainsKey(levelName))
            {
                var currentHighscore100 = saveData.LevelHighscores100[levelName];
                if (score100 > currentHighscore100)
                {
                    menuManager.GetMenuByType<GameFinishedMenu>(menu => 
                    {
                        menu.setTitleText("New Highscore!");
                        menu.highscoreParticles.gameObject.SetActive(true);
                    });
                    saveData.LevelHighscores100[levelName] = score100;
                    saveData.WriteToFile();
                }
                else
                {
                    menuManager.GetMenuByType<GameFinishedMenu>(menu => 
                    {
                        menu.setTitleText("- Your Score -");
                        menu.highscoreParticles.gameObject.SetActive(false);
                    });
                }
            }
            else
            {
                menuManager.GetMenuByType<GameFinishedMenu>(menu =>
                {
                    menu.setTitleText("New Highscore!");
                });
                saveData.LevelHighscores100[levelName] = score100;
                saveData.WriteToFile();
            }

            // show finished menu
            menuManager.GetMenuByType<GameFinishedMenu>(menu =>
            {
                menu.setScoreText(score100);
            });
            menuManager.HideCurrentAndShow(menuManager.GetMenuByType<GameFinishedMenu>(), parallel: true);
        }

        private IEnumerator ConcealMismatchedCards()
        {
            ignoreClickEvents = true;
            firstCardRevealed.PlayMismatchedAnimation();
            secondCardRevealed.PlayMismatchedAnimation();
            yield return new WaitForSeconds(revealDuration);
            firstCardRevealed.Conceal();
            secondCardRevealed.Conceal();
            firstCardRevealed = null;
            secondCardRevealed = null;
            ignoreClickEvents = false;
        }

        private IEnumerator HideMatchedCards(PairsCard first, PairsCard second)
        {
            yield return new WaitForSeconds(1);
            try
            {
                first.gameObject.SetActive(false);
                second.gameObject.SetActive(false);
            }
            catch
            {
                // cards might have been destroyed already because the player switched to another screen
            }
        }

        private bool DoCardsMatch(PairsCard first, PairsCard second)
        {
            if (pairsDict.ContainsKey(first.TextContent))
            {
                return pairsDict[first.TextContent].Latin == second.TextContent;
            }

            if (pairsDict.ContainsKey(second.TextContent))
            {
                return pairsDict[second.TextContent].Latin == first.TextContent;
            }

            return false;
        }

        private void BoardOnCardClicked(PairsCard card)
        {
            if (!ignoreClickEvents && !matchedCards.Contains(card))
            {
                if (firstCardRevealed == null)
                {
                    // reveal first card
                    firstCardRevealed = card;
                    firstCardRevealed.Reveal();

                    Debug.Log($"First card: {firstCardRevealed.TextContent}");
                }
                else if (secondCardRevealed == null && card != firstCardRevealed)
                {
                    attempts++;

                    // reveal second card
                    secondCardRevealed = card;
                    secondCardRevealed.Reveal();

                    // keep a reference to first/second card
                    var firstCard = firstCardRevealed;
                    var secondCard = secondCardRevealed;

                    // if cards match disable collision and allow the player to immediately select another pair
                    // var cardsMatch = pairsDict.ContainsPair(firstCard.TextContent, secondCard.TextContent);
                    var cardsMatch = DoCardsMatch(firstCard, secondCard);

                    Debug.Log($"Match? '{cardsMatch}' for '{firstCard.TextContent}' -> '{secondCard.TextContent}'");
                    if (cardsMatch)
                    {
                        matchedCards.Add(firstCardRevealed);
                        matchedCards.Add(secondCardRevealed);
                        firstCardRevealed = null;
                        secondCardRevealed = null;
                        matches++;
                        if (matches >= (Board.boardRows * Board.boardCols / 2))
                        {
                            GameFinished();
                        }
                    }

                    // wait for reveal animation to finish
                    PairsCard.RevealAnimFinishedEvent revealFinished = null;
                    secondCard.RevealAnimFinished += revealFinished = () =>
                    {
                        if (cardsMatch)
                        {
                            // destroy matching cards
                            firstCard.Dissolve();
                            secondCard.Dissolve();
                            StartCoroutine(HideMatchedCards(firstCard, secondCard));
                        }
                        else
                        {
                            // else conceal them, then allow the player to select another pair
                            StartCoroutine(ConcealMismatchedCards());
                            secondCard.RevealAnimFinished -= revealFinished;
                        }
                    };
                }
            }
        }
    }
}