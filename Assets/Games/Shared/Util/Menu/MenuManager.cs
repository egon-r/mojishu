using System;
using System.Collections.Generic;
using UnityEngine;

namespace Games.Shared.Util.Menu
{
    public class MenuManager: MonoBehaviour
    {
        public CanvasGroup DefaultMenu;
        public List<CanvasGroup> Menus;
        private CanvasGroup CurrentMenu;

        private void Start()
        {
            Menus.ForEach(m => m.gameObject.SetActive(false));
            ShowMenu(DefaultMenu);
        }

        public void HideCurrentAndShow(CanvasGroup menu, Action onComplete = null, bool parallel = false)
        {
            if (parallel)
            {
                var completed = false;
                HideMenu(CurrentMenu, () =>
                {
                    lock (CurrentMenu)
                    {
                        if (!completed)
                        {
                            completed = true;
                            onComplete?.Invoke();
                        }
                    }
                });
                ShowMenu(menu, () =>
                {
                    lock (CurrentMenu)
                    {
                        if (!completed)
                        {
                            completed = true;
                            onComplete?.Invoke();
                        }
                    }
                });
            }
            else
            {
                HideMenu(CurrentMenu, () =>
                {
                    ShowMenu(menu, onComplete);
                });
            }
        }
        
        public CanvasGroup GetMenuByType<T>()
        {
            return GetMenuByType(typeof(T));
        }
        
        public CanvasGroup GetMenuByType(Type menuType)
        {
            foreach (var menu in Menus)
            {
                if (menu.TryGetComponent(menuType, out _))
                {
                    return menu;
                }
            }

            return null;
        }

        public void ShowMenu(CanvasGroup menu, Action onComplete = null, bool hideOthers = true)
        {
            AnimatedMenu animMenu = menu.gameObject.GetComponent<AnimatedMenu>();
            menu.gameObject.SetActive(true);
            CurrentMenu = menu;
            if (animMenu == null)
            {
                onComplete?.Invoke();
            }
            else
            {
                animMenu.PlayShowAnimation(onComplete);
            }
        }
        
        public void HideMenu(CanvasGroup menu, Action onComplete = null)
        {
            AnimatedMenu animMenu = menu.gameObject.GetComponent<AnimatedMenu>();
            if (animMenu == null)
            {
                menu.gameObject.SetActive(false);
                onComplete?.Invoke();
            }
            else
            {
                animMenu.PlayHideAnimation(() =>
                {
                    menu.gameObject.SetActive(false);
                    onComplete?.Invoke();
                });
            }
        }
    }
}