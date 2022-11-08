using System;
using TMPro;
using UnityEngine;

namespace Games.Pairs
{
    public class PairsCard : MonoBehaviour
    {
        private string _textContent;
        public string TextContent
        {
            set
            {
                GetComponentInChildren<TextMeshPro>().text = value;
                _textContent = value;
            }
            get
            {
                return _textContent;
            }
        }
        
        private bool isRevealed = false;
        private bool revealing = false;
        private bool concealing = false;
        private Quaternion revealedRotation = Quaternion.Euler(0, 180, 0);
        private Quaternion hiddenRotation = Quaternion.Euler(0, 0, 0);

        public delegate void ClickedEvent();
        public event ClickedEvent Clicked;
        
        public delegate void RevealAnimFinishedEvent();
        public event RevealAnimFinishedEvent RevealAnimFinished;
        
        public delegate void ConcealAnimFinishedEvent();
        public event ConcealAnimFinishedEvent ConcealAnimFinished;

        private void OnMouseDown()
        {
            RaiseClickedEvent();
        }

        public void Reveal()
        {
            isRevealed = true;
        }

        public void Conceal()
        {
            isRevealed = false;
        }

        private void Update()
        {
            if (isRevealed && !transform.rotation.Equals(revealedRotation))
            {
                transform.rotation = Quaternion.RotateTowards(
                    transform.rotation,
                    revealedRotation,
                    350.0f * Time.deltaTime
                );
                revealing = true;
            }
            if (revealing && transform.rotation.Equals(revealedRotation))
            {
                RaiseRevealAnimFinished();
                revealing = false;
            }

            if (!isRevealed && !transform.rotation.Equals(hiddenRotation))
            {
                transform.rotation = Quaternion.RotateTowards(
                    transform.rotation,
                    hiddenRotation,
                    350.0f * Time.deltaTime
                );
                concealing = true;
            }

            if (concealing && transform.rotation.Equals(hiddenRotation))
            {
                RaiseConcealAnimFinished();
                concealing = false;
            }
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