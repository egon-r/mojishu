using System;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Pairs
{
    public class PairsBoard : MonoBehaviour
    {
        public GameObject pairsCard;
        public int boardCols = 4;
        public int boardRows = 6;
        public float boardColSpacing = 0.1f;
        public float boardRowSpacing = 0.1f;
        public string[,] cardTextData;
        private List<PairsCard> _cards = new List<PairsCard>();
        private List<GameObject> _tmpCards = new List<GameObject>(); // store temporary cards, destroy later (destroy is expensive and causes lag)

        public delegate void CardClickedHandler(PairsCard card);
        public event CardClickedHandler CardClicked;

        public void Initialize(string[,] cardData)
        {
            Clear();
            
            // check data array size
            if (cardData.GetLength(0) == boardRows && cardData.GetLength(1) == boardCols)
            {
                cardTextData = cardData;
            }
            else
            {
                throw new Exception("cardData size doesn't match board size!");
            }
            
            // get screen size
            Vector2 screenSizeInWorld = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
            screenSizeInWorld *= 2;
            Debug.Log(screenSizeInWorld);

            // create temporary card to determine size
            var tmpCard = Instantiate(pairsCard, Vector3.zero, Quaternion.identity);
            var cardSize = tmpCard.GetComponentInChildren<BoxCollider2D>().bounds.size;
            tmpCard.gameObject.SetActive(false);
            _tmpCards.Add(tmpCard);

            // calculate total board size
            float boardWidth = (cardSize.x * boardCols) + (boardColSpacing * (boardCols - 1));
            float boardHeight = (cardSize.y * boardRows) + (boardRowSpacing * (boardRows - 1));
            
            // calculate top left point
            float boardLeftStart = ((screenSizeInWorld.x - boardWidth) / 2) - (screenSizeInWorld.x / 2);
            float boardTopStart = -1 * (((screenSizeInWorld.y - boardHeight) / 2) - (screenSizeInWorld.y / 2));

            // offset by cardSize/2
            boardLeftStart += (cardSize.x / 2);
            boardTopStart -= (cardSize.y / 2);

            // spawn cards
            Vector3 nextPosition = new Vector3(boardLeftStart, boardTopStart, 0);
            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardCols; col++)
                {
                    var cardGameObject = Instantiate(pairsCard, nextPosition, Quaternion.identity, transform);
                    var card = cardGameObject.GetComponent<PairsCard>();
                    card.Conceal(true);
                    card.TextContent = cardTextData[row, col];
                    card.Clicked += () =>
                    {
                        RaiseCardClickedEvent(card);
                    };
                    _cards.Add(card);
                    nextPosition.x += cardSize.x + boardColSpacing;
                }
                nextPosition.y -= cardSize.y + boardRowSpacing;
                nextPosition.x = boardLeftStart;
            }
        }

        public void HideBoard()
        {
            foreach (var card in _cards)
            {
                card.gameObject.SetActive(false);
            }
        }

        public void ShowBoard()
        {
            foreach (var card in _cards)
            {
                card.gameObject.SetActive(true);
            }
        }
        
        public void Clear()
        {
            foreach (var card in _cards)
            {
                Destroy(card.gameObject);
            }
            _tmpCards.ForEach(Destroy);
            _cards.Clear();
        }
        
        public List<PairsCard> GetCards()
        {
            return _cards;
        }

        protected virtual void RaiseCardClickedEvent(PairsCard card)
        {
            CardClicked?.Invoke(card);
        }
    }
}