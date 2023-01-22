using System;
using System.IO;
using Games.Shared.Data;
using Games.Shared.Util;
using Kawazu;
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
                text += "\nOnyomi: ";
                for (int i = 0; i < value.Onyomi.Count; i++)
                {
                    if (i > 0)
                    {
                        text += ", ";
                    }
                    text += $"{JPConvert.KanaToRomaji(value.Onyomi[i])}";
                }
            }
            
            // kunyomi readings
            text += "\n\n訓: ";
            text += String.Join("、 ", value.Kunyomi);
            if (ShowRomaji)
            {
                text += "\nKunyomi: ";
                for (int i = 0; i < value.Kunyomi.Count; i++)
                {
                    if (i > 0)
                    {
                        text += ", ";
                    }
                    text += $"{JPConvert.KanaToRomaji(value.Kunyomi[i])}";
                }
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
