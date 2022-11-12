using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using Games.Pairs.Savegame;
using Games.Pairs.UI;
using UnityEngine;
using Random = System.Random;

namespace Games.Pairs
{
    public class PairsGame : MonoBehaviour
    {
        public PairsBoard Board;
        public PairsMenuManager menuManager;

        private PairsSaveData saveData = new PairsSaveData();
        private float initialBoardRevealDuration = 3;
        private float revealDuration = 2;
        private bool ignoreClickEvents = false;
        private PairsCard firstCardRevealed = null;
        private PairsCard secondCardRevealed = null;
        private int matches = 0;
        private int attempts = 0;
        private Dictionary<string, string> pairsDict;
        private List<PairsCard> matchedCards = new List<PairsCard>();
        private string levelName = "unknown_level";

        public void Initialize(PairsGameInitData pairsGameInitData)
        {
            Debug.Log($"Initializing '{pairsGameInitData.levelName}'...");
            Debug.Log($"Next Level: '{menuManager.levelSelectMenuHandler.GetNextLevel(pairsGameInitData.levelName)?.GameInitData.levelName}'");
            
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
                pairItems.Add(rndPair.Value);
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

            // initial reveal
            if (initialBoardRevealDuration > 0)
            {
                StartCoroutine(InitialBoardReveal());
            }
        }
        
        private IEnumerator InitialBoardReveal()
        {
            ignoreClickEvents = true;
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
                    menuManager.gameFinishedMenu.setTitleText("New Highscore!");
                    menuManager.gameFinishedMenu.highscoreParticles.gameObject.SetActive(true);
                    saveData.LevelHighscores100[levelName] = score100;
                    saveData.WriteToFile();
                }
                else
                {
                    menuManager.gameFinishedMenu.setTitleText("- Your Score -");
                    menuManager.gameFinishedMenu.highscoreParticles.gameObject.SetActive(false);
                }
            }
            else
            {
                menuManager.gameFinishedMenu.setTitleText("New Highscore!");
                saveData.LevelHighscores100[levelName] = score100;
                saveData.WriteToFile();
            }
            
            // show finished menu
            menuManager.gameFinishedMenu.setScoreText(score100);
            menuManager.gameFinishedMenu.CurrentLevelName = levelName;
            menuManager.gameFinishedMenu.SlideInFromTop();
            menuManager.ShowMenu(menuManager.gameFinishedMenu.gameObject);
        }
        
        private IEnumerator ConcealCards()
        {
            ignoreClickEvents = true;
            yield return new WaitForSeconds(revealDuration);
            firstCardRevealed.Conceal();
            secondCardRevealed.Conceal();
            firstCardRevealed = null;
            secondCardRevealed = null;
            ignoreClickEvents = false;
        }

        private IEnumerator HideMatchedCards(PairsCard firstCard, PairsCard secondCard)
        {
            yield return new WaitForSeconds(1);
            try
            {
                firstCard.gameObject.SetActive(false);
                secondCard.gameObject.SetActive(false);
            }
            catch
            {
                // cards might have been destroyed already because the player switched to another screen
            }
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
                    var cardsMatch = pairsDict.ContainsPair(firstCard.TextContent, secondCard.TextContent);
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
                            StartCoroutine(ConcealCards());
                            secondCard.RevealAnimFinished -= revealFinished;
                        }
                    };
                }
            }
        }
    }
}