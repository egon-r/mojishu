using System;
using System.Threading;
using DigitalRuby.Tween;
using TMPro;
using UnityEngine;

namespace Games.Pairs
{
    public class PairsCard : MonoBehaviour
    {
        public GameObject CardBack;
        public GameObject CardFrontText;

        private string _textContent;

        public string TextContent
        {
            set
            {
                GetComponentInChildren<TextMeshPro>().text = value;
                _textContent = value;
            }
            get { return _textContent; }
        }

        private bool isRevealed = false;
        private bool revealing = false;
        private bool concealing = false;
        private Quaternion revealedRotation = Quaternion.Euler(0, 0, 0);
        private Quaternion concealedRotation = Quaternion.Euler(0, 180, 0);

        public delegate void ClickedEvent();

        public event ClickedEvent Clicked;

        public delegate void RevealAnimFinishedEvent();

        public event RevealAnimFinishedEvent RevealAnimFinished;

        public delegate void ConcealAnimFinishedEvent();

        public event ConcealAnimFinishedEvent ConcealAnimFinished;

        public bool debugMode = false;

        private void OnMouseDown()
        {
            if (debugMode)
            {
                if (isRevealed)
                {
                    Conceal();
                }
                else
                {
                    Reveal();
                }
            }

            if (!revealing && !concealing)
            {
                RaiseClickedEvent();
            }
        }

        public void Reveal(bool skipAnim = false)
        {
            isRevealed = true;

            if (skipAnim)
            {
                gameObject.transform.rotation = revealedRotation;
            }
            
            System.Action<ITween<Quaternion>> rotateAnim = (t) =>
            {
                gameObject.transform.rotation = Quaternion.identity;
                gameObject.transform.rotation = t.CurrentValue;
            };
            var start = gameObject.transform.rotation;
            var end = revealedRotation;
            gameObject.Tween(
                rotateAnim,
                start, end, 0.6f,
                TweenScaleFunctions.CubicEaseOut,
                rotateAnim,
                _ => RaiseRevealAnimFinished()
            );
        }

        public void Conceal(bool skipAnim = false)
        {
            isRevealed = false;
            
            if (skipAnim)
            {
                gameObject.transform.rotation = concealedRotation;
            }
            
            System.Action<ITween<Quaternion>> rotateAnim = (t) =>
            {
                gameObject.transform.rotation = Quaternion.identity;
                gameObject.transform.rotation = t.CurrentValue;
            };
            var start = gameObject.transform.rotation;
            var end = concealedRotation;
            gameObject.Tween(
                rotateAnim,
                start, end, 0.3f,
                TweenScaleFunctions.Linear,
                rotateAnim,
                _ => RaiseConcealAnimFinished()
            );
        }

        public void PlayMismatchedAnimation()
        {
            System.Action<ITween<float>> rotateAnim = (t) =>
            {
                gameObject.transform.rotation = Quaternion.identity;
                // sin to make it wiggle
                var rotZ = (float)Math.Sin(t.CurrentProgress*Math.PI*3) * 20.0f;
                gameObject.transform.Rotate(0.0f, 0.0f, rotZ);
            };
            gameObject.Tween(
                rotateAnim,
                0.0f, 1.0f, 0.4f,
                TweenScaleFunctions.Linear,
                rotateAnim
            );
        }

        public void Dissolve()
        {
            Action<ITween<float>> dissolveCard = (t) =>
            {
                CardBack.GetComponent<SpriteRenderer>().material.SetFloat("_Dissolve", t.CurrentValue);
                CardFrontText.GetComponent<MeshRenderer>().material.SetFloat("_Dissolve", t.CurrentValue);
            };
            var dissolveStart = 1.0f;
            var dissolveEnd = 0.0f;
            CardBack.gameObject.Tween(
                dissolveCard,
                dissolveStart,
                dissolveEnd,
                1.0f,
                TweenScaleFunctions.SineEaseInOut,
                dissolveCard
            );
        }

        protected virtual void RaiseRevealAnimFinished()
        {
            RevealAnimFinished?.Invoke();
        }

        protected virtual void RaiseConcealAnimFinished()
        {
            ConcealAnimFinished?.Invoke();
        }

        protected virtual void RaiseClickedEvent()
        {
            Clicked?.Invoke();
        }
    }
}