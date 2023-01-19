using System;
using System.Collections.Generic;
using Games.Shared.Data;
using UnityEngine;

namespace Games.KanjiQuiz
{
    [RequireComponent(typeof(WorldGridLayout))]
    public class KanjiQuizAnswers : MonoBehaviour
    {
        public KanjiQuizAnswerCard AnswerCardPrefab;

        public WorldGridLayout Grid
        {
            get
            {
                return GetComponent<WorldGridLayout>();
            }
        }

        public void SpawnCards(IList<KanjiInfo> kanjiInfos, Action<KanjiQuizAnswerCard> onCardSpawned = null)
        {
            Grid.Items.ForEach(Destroy);
            Grid.Items.Clear();
            
            foreach (var kanjiInfo in kanjiInfos)
            {
                var prefab = Instantiate(AnswerCardPrefab);
                onCardSpawned?.Invoke(prefab);
                prefab.gameObject.SetActive(false);
                prefab.Kanji = kanjiInfo;
                Grid.Items.Add(prefab.gameObject);
            }
            
            Grid.LayoutItems();
            foreach (var item in Grid.Items)
            {
                item.SetActive(true);
            }
        }
    }
}
