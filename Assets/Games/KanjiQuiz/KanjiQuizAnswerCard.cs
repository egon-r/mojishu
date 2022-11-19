using System;
using System.Collections;
using System.Collections.Generic;
using Games.Shared.Data;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;


public class KanjiQuizAnswerCard : MonoBehaviour
{
    private enum CardState
    {
        DEFAULT, CORRECT, WRONG, PRESSED
    }
    
    public Sprite DefaultBackground;
    public Sprite WrongBackground;
    public Sprite CorrectBackground;
    public Sprite PressedBackground;
    public SpriteRenderer CardBackground;
    public TextMeshPro CardText;
    private KanjiInfo _kanji;
    private CardState state = CardState.DEFAULT;
    
    public KanjiInfo Kanji
    {
        get => _kanji;
        set
        {
            _kanji = value;
            CardText.text = value.kanjiSymbol;
        }
    }
    
    public delegate void ClickedEvent(KanjiQuizAnswerCard card);
    public event ClickedEvent Clicked;

    private void OnMouseUpAsButton()
    {
        if (Time.timeScale != 0)
        {
            state = CardState.DEFAULT;
            CardBackground.sprite = PressedBackground;
            RaiseClickedEvent(this);
        }
    }

    private void OnMouseDown()
    {
        if (state == CardState.DEFAULT && Time.timeScale != 0)
        {
            state = CardState.PRESSED;
            CardBackground.sprite = PressedBackground;
        }
    }

    private void OnMouseUp()
    {
        if (state == CardState.PRESSED && Time.timeScale != 0)
        {
            state = CardState.DEFAULT;
            CardBackground.sprite = DefaultBackground;
        }
    }

    public void MarkAsWrong()
    {
        state = CardState.WRONG;
        CardBackground.sprite = WrongBackground;
        var color = CardText.color;
        color.a = 0.5f;
        CardText.color = color;
    }
    
    protected virtual void RaiseClickedEvent(KanjiQuizAnswerCard card)
    {
        Clicked?.Invoke(card);
    }
}
