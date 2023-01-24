using System;
using Games.Shared.Data;
using Games.Shared.Util;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class KanjiQuizQuestionPanel : MonoBehaviour, IPointerClickHandler
{
    public VerticalLayoutGroup ContentLayout;
    public TextMeshProUGUI ContentText;

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
            RenderQuestionPanelText(_kanji);
        }
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        var linkIndex = TMP_TextUtilities.FindIntersectingLink(ContentText, Input.mousePosition, Camera.main);
        Debug.Log($"click, index: {linkIndex}");
        if (linkIndex >= 0)
        {
            var linkInfo = ContentText.textInfo.linkInfo[linkIndex];
            if (linkInfo.GetLinkID() == "jisho-link")
            {
                Application.OpenURL("https://jisho.org/search/%23kanji%20" + _kanji.Kanji);
            } 
        }
    }
    
    private void RenderQuestionPanelText(KanjiInfo kanji)
    {
        // kunyomi
        var text = "<b><u>訓 (Kunyomi)</u></b>\n";
        text += "<indent=1em>";
        text += GetKunyomiKana(kanji);
        text += "\n";
        if (ShowRomaji)
        {
            text += GetKunyomiRomaji(kanji);
        }
        text += "</indent>";
        
        // onyomi
        text += "\n\n<b><u>音 (Onyomi)</u></b>\n";
        text += "<indent=1em>";
        text += GetOnyomiKana(kanji);
        text += "\n";
        if (ShowRomaji)
        {
            text += GetOnyomiRomaji(kanji);
        }
        text += "</indent>";
        
        // nanori
        text += "\n\n<b><u>名乗り (Nanori)</u></b>\n";
        text += "<indent=1em>";
        text += GetNanoriKana(kanji);
        text += "\n";
        if (ShowRomaji)
        {
            text += GetNanoriRomaji(kanji);
        }
        text += "</indent>";
        
        // english
        if (ShowEnglishTranslations)
        {
            text += "\n\n<b><u>English</u></b>\n";
            text += "<indent=1em>";
            text += String.Join(", ", kanji.English);
            text += "</indent>";
        }

        // radicals
        text += "\n\n<b><u>Radicals</u></b>";
        text += "<indent=1em>";
        foreach (var radical in kanji.Radicals)
        {
            text += $"\n{radical}";
        }
        text += "</indent>";
        
        // examples
        text += "\n\n<b><u>Examples</u></b>";
        foreach (var example in kanji.Examples)
        {
            text += $"\n<indent=1em>{example.Kanji}</indent>";
            text += $"\n<indent=1em>{example.Kana}</indent>";
            text += $"\n<indent=1em>{example.English}</indent>\n";
        }

        // jisho link
        text += "\n\n<align=\"right\"><color=#2e2eff><link=\"jisho-link\">view on jisho.org</link></color></align>";

        ContentText.text = text;
    }

    private string GetOnyomiKana(KanjiInfo kanji)
    {
        return String.Join("、 ", kanji.Onyomi);
    }
    
    private string GetOnyomiRomaji(KanjiInfo kanji)
    {
        var result = "";
        for (int i = 0; i < kanji.Onyomi.Count; i++)
        {
            if (i > 0)
            {
                result += ", ";
            }
            result += $"{JPConvert.KanaToRomaji(kanji.Onyomi[i])}";
        }
        return result;
    }
    
    private string GetKunyomiKana(KanjiInfo kanji)
    {
        return String.Join("、 ", kanji.Kunyomi);
    }

    private string GetKunyomiRomaji(KanjiInfo kanji)
    {
        var result = "";
        for (int i = 0; i < kanji.Kunyomi.Count; i++)
        {
            if (i > 0)
            {
                result += ", ";
            }
            result += $"{JPConvert.KanaToRomaji(kanji.Kunyomi[i])}";
        }
        return result;
    }

    private string GetNanoriKana(KanjiInfo kanji)
    {
        return String.Join("、 ", kanji.Nanori);
    }

    private string GetNanoriRomaji(KanjiInfo kanji)
    {
        var result = "";
        for (int i = 0; i < kanji.Nanori.Count; i++)
        {
            if (i > 0)
            {
                result += ", ";
            }
            result += $"{JPConvert.KanaToRomaji(kanji.Nanori[i])}";
        }
        return result;
    }
}
