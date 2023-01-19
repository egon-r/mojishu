using System;
using Games.Shared.Data;
using TMPro;
using UnityEngine;

public class KanjiQuizQuestionPanel : MonoBehaviour
{
    public TextMeshProUGUI CardText;

    private bool _showRomaji;
    public bool ShowRomaji
    {
        get => _showRomaji;
        set
        {
            _showRomaji = value;
            if (_kanji != null)
            {
                Kanji = _kanji;
            }
        }
    }
    
    private bool _showEnglishTranslations;
    public bool ShowEnglishTranslations
    {
        get => _showEnglishTranslations;
        set
        {
            _showEnglishTranslations = value;
            if (_kanji != null)
            {
                Kanji = _kanji;
            }
        }
    }

    private KanjiInfo _kanji;
    public KanjiInfo Kanji
    {
        get => _kanji;
        set
        {
            _kanji = value;

            var text = "";
            
            // onyomi readings
            text += "音: ";
            text += String.Join("、 ", value.Onyomi);
            if (ShowRomaji)
            {
                text += "\nOnyomi: TODO";
                //text += String.Join(", ", value.onyomiReadingsLatin);
            }
            
            // kunyomi readings
            text += "\n\n訓: ";
            text += String.Join("、 ", value.Kunyomi);
            if (ShowRomaji)
            {
                text += "\nKunyomi: TODO";
                //text += String.Join(", ", value.kunyomiReadingsLatin);
            }
            
            // english translation
            if (ShowEnglishTranslations)
            {
                text += "\n";
                text += "\nEnglish: ";
                text += String.Join(", ", value.English);
            }
            
            CardText.text = text;
        }
    }
}
