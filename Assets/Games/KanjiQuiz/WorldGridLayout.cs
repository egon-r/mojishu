using System;
using System.Collections.Generic;
using UnityEngine;

namespace Games.KanjiQuiz
{
    public class WorldGridLayout: MonoBehaviour
    {
        public List<GameObject> Items = new();

        public void LayoutItems(int rows = 2, float maxHeight = 5)
        {
            float boardPadding = 0.1f;
            float spacing = 0.05f;
            
            int columns = (int)Math.Ceiling(Items.Count / (double)rows);
            Debug.Log("columns: " + columns );
            
            // get screen size
            Vector2 screenSizeInWorld = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
            screenSizeInWorld *= 2;

            // temporary board size (max size)
            float boardWidth = screenSizeInWorld.x - boardPadding * 2 - (columns - 1) * spacing;
            float boardHeight = screenSizeInWorld.y - boardPadding * 2 - (rows - 1) * spacing;
            if (boardHeight > maxHeight)
            {
                boardHeight = maxHeight;
            }
            
            // card size
            float cardWidth = boardWidth / columns;
            float cardHeight = boardHeight / rows;
            float cardSize = Math.Min(cardWidth, cardHeight);
            
            // final board size
            boardWidth = cardSize * columns + boardPadding * 2 + (columns - 1) * spacing;
            boardHeight = cardSize * rows + boardPadding * 2 + (rows - 1) * spacing;

            // spawn start pos
            Vector2 itemSpawnStart = new Vector2(
                (boardWidth / 2 - (cardSize / 2) - boardPadding) * -1,
                (boardHeight / 2 - (cardSize / 2) - boardPadding) * -1
            );
            itemSpawnStart.x += transform.position.x;
            itemSpawnStart.y += transform.position.y;
            Debug.Log("pos: " + transform.position.x);
            Debug.Log("pos: " + transform.position.y);
            
            // spawn
            Vector2 nextPosition = itemSpawnStart;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    var currentIndex = (row * columns) + col;
                    if (currentIndex >= Items.Count)
                    {
                        continue;
                    }
                    var currentItem = Items[currentIndex];
                    currentItem.transform.parent = transform;
                    currentItem.transform.localScale = new Vector3(cardSize, cardSize, cardSize);
                    currentItem.transform.position = new Vector3(nextPosition.x, nextPosition.y, 0);

                    nextPosition.x += (cardSize + spacing);
                }

                nextPosition.x = itemSpawnStart.x;
                nextPosition.y += (cardSize + spacing);
            }
        }
    }
}