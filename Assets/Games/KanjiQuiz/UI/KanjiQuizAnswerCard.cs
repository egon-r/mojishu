using System;
using DigitalRuby.Tween;
using Games.Shared.Data;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Games.KanjiQuiz
{
    public class KanjiQuizAnswerCard : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
    {
        public enum CardState
        {
            DEFAULT,
            CORRECT,
            WRONG,
        }

        public Sprite DefaultBackground;
        public Sprite WrongBackground;
        public Sprite CorrectBackground;
        public Sprite PressedBackground;
        public Image CardBackground;
        public TextMeshProUGUI CardText;
        public CardState state = CardState.DEFAULT;
        public Boolean IgnorePointerEvents = false;
        private KanjiInfo _kanji;

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

        public void OnPointerDown(PointerEventData eventData)
        {
            if (Time.timeScale != 0 && !IgnorePointerEvents)
            {
                CardBackground.sprite = PressedBackground;
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (Time.timeScale != 0 && !IgnorePointerEvents)
            {
                CardBackground.sprite = DefaultBackground;
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (Time.timeScale != 0 && !IgnorePointerEvents)
            {
                RaiseClickedEvent(this);
            }
        }

        public void MarkAsCorrect()
        {
            IgnorePointerEvents = true;
            state = CardState.CORRECT;
            
            transform.SetParent(transform.parent.parent); // remove from layout
            
            Action<ITween<Vector3>> translateAnim = (t) =>
            {
                transform.localPosition = t.CurrentValue;
            };
            var startPos = transform.localPosition;
            gameObject.Tween(
                translateAnim,
                startPos, new Vector3(0.0f, -400.0f, 1.0f),
                0.2f, TweenScaleFunctions.CubicEaseOut, translateAnim
            );
            
            Action<ITween<Vector3>> scaleAnim = (t) =>
            {
                transform.localScale = t.CurrentValue;
            };
            var startScale = transform.localScale;
            gameObject.Tween(scaleAnim, 
                startScale, new Vector3(2.0f, 2.0f, 2.0f),
                0.2f, TweenScaleFunctions.CubicEaseOut, scaleAnim,
                _ => IgnorePointerEvents = false
            );
        }

        public void MarkAsWrong()
        {
            IgnorePointerEvents = true;
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
}