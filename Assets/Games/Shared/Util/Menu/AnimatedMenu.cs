using System;
using DigitalRuby.Tween;
using UnityEngine;

namespace Games.Shared.Util.Menu
{
    public class AnimatedMenu : MonoBehaviour
    {
        public enum AnimationType
        {
            SLIDE_FROM_TOP, 
            SLIDE_FROM_BOTTOM, 
            SLIDE_FROM_LEFT, 
            SLIDE_FROM_RIGHT, 
        }

        public AnimationType Animation;
        public float AnimationDuration = 0.4f;
        public RectTransform AnimTarget;

        private Vector3 getSlideStartPosition(AnimationType anim)
        {
            switch (anim)
            {
                case AnimationType.SLIDE_FROM_TOP:
                    return new Vector3(0, Screen.height, 0);
                case AnimationType.SLIDE_FROM_BOTTOM:
                    return new Vector3(0, -2 * Screen.height, 0);
                case AnimationType.SLIDE_FROM_LEFT:
                    return new Vector3(-2 * Screen.width, 0, 0);
                case AnimationType.SLIDE_FROM_RIGHT:
                    return new Vector3(Screen.width, 0, 0);
                default:
                    return Vector3.zero;
            }
        }

        public MenuManager getMenuManager()
        {
            return gameObject.GetComponentInParent<MenuManager>();
        }

        public virtual void PlayShowAnimation(Action onComplete = null)
        {
            System.Action<ITween<Vector3>> slideIn = t =>
            {
                AnimTarget.GetComponent<RectTransform>().localPosition = t.CurrentValue;
            };
            
            var slideStart = getSlideStartPosition(Animation);
            var slideEnd = Vector3.zero;
            
            AnimTarget.gameObject.Tween(
                slideIn,
                slideStart, 
                slideEnd,
                AnimationDuration, 
                TweenScaleFunctions.CubicEaseOut,
                slideIn,
                _ => onComplete?.Invoke()
            );
        }
        
        public virtual void PlayHideAnimation(Action onComplete = null)
        {
            System.Action<ITween<Vector3>> slideIn = t =>
            {
                AnimTarget.GetComponent<RectTransform>().localPosition = t.CurrentValue;
            };
            
            var slideStart = Vector3.zero;
            var slideEnd = getSlideStartPosition(Animation);
            
            AnimTarget.gameObject.Tween(
                slideIn,
                slideStart, 
                slideEnd,
                AnimationDuration, 
                TweenScaleFunctions.CubicEaseIn,
                slideIn,
                _ => onComplete?.Invoke()
            );
        }
    }
}