using System;
using System.Collections;
using UnityEngine;

namespace Games.Pairs
{
    public class PairsGame : MonoBehaviour
    {
        public PairsBoard Board;
        private float revealDuration = 3;
        private bool isConcealing = false;
        private PairsCard firstCardRevealed = null;
        private PairsCard secondCardRevealed = null;

        private void Start()
        {
            Board.boardCols = 4;
            Board.boardRows = 4;
            Board.Initialize(new string[4,4]
            {
                {"1", "2", "3", "4"},
                {"5", "6", "7", "8"},
                {"1", "2", "3", "4"},
                {"5", "6", "7", "8"},
            });
            Board.CardClicked += BoardOnCardClicked;
        }

        private IEnumerator ConcealCards()
        {
            isConcealing = true;
            yield return new WaitForSeconds(revealDuration);
            firstCardRevealed.Conceal();
            secondCardRevealed.Conceal();
            firstCardRevealed = null;
            secondCardRevealed = null;
            isConcealing = false;
        }

        private void BoardOnCardClicked(PairsCard card)
        {
            if (!isConcealing)
            {
                if (firstCardRevealed == null)
                {
                    firstCardRevealed = card;
                    firstCardRevealed.Reveal();
                }
                else if(secondCardRevealed == null && card != firstCardRevealed)
                {
                    secondCardRevealed = card;
                    secondCardRevealed.Reveal();

                    PairsCard.RevealAnimFinishedEvent revealFinished = null;
                    secondCardRevealed.RevealAnimFinished += revealFinished = () =>
                    {
                        if (firstCardRevealed.TextContent == secondCardRevealed.TextContent)
                        {
                            Destroy(firstCardRevealed.gameObject);
                            Destroy(secondCardRevealed.gameObject);
                            firstCardRevealed = null;
                            secondCardRevealed = null;
                        }
                        else
                        {
                            StartCoroutine(ConcealCards());
                            secondCardRevealed.RevealAnimFinished -= revealFinished;
                        }
                    };
                }
            }
        }
    }
}