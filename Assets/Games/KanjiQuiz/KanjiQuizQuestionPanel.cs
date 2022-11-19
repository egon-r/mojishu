using System;
using System.Collections;
using System.Collections.Generic;
using Games.Shared.Data;
using TMPro;
using UnityEngine;

public class KanjiQuizQuestionPanel : MonoBehaviour
{
    public TextMeshProUGUI CardText;
    private KanjiInfo _kanji;

    public KanjiInfo Kanji
    {
        get => _kanji;
        set
        {
            _kanji = value;

            var text = "";
            text += "音: "; //ON
            text += String.Join("、 ", value.onyomiReadingsKana);
            text += "\nOnyomi: ";
            text += String.Join(", ", value.onyomiReadingsLatin);
            text += "\n訓: "; //KUN
            text += String.Join("、 ", value.kunyomiReadingsKana);
            text += "\nKunyomi: ";
            text += String.Join(", ", value.kunyomiReadingsLatin);
            text += "\n";
            text += "\nEnglish: ";
            text += String.Join(", ", value.englishTranslations);
            
            CardText.text = text;
        }
    }
}
