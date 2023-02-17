using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Games.Shared.Util.Menu
{
    public class MenuManager: MonoBehaviour
    {
        [Header("Setup")]
        public List<CanvasGroup> Menus;
        public CanvasGroup InitialMenu;
        private CanvasGroup CurrentMenu;

        private void Start()
        {
            ShowMenu(InitialMenu);
        }

        public void HideCurrentMenu(Action onComplete = null)
        {
            HideMenu(CurrentMenu, onComplete);
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
        
        public CanvasGroup GetMenuByType<T>(Action<T> withMenu = null)
        {
            foreach (var menu in Menus)
            {
                Component comp = null;
                if (menu.TryGetComponent(typeof(T), out comp))
                {
                    if (comp is T compT)
                    {
                        withMenu?.Invoke(compT);
                        //component = compT;
                    }
                    return menu;
                }
            }
            return null;
        }

        public void ShowMenu(CanvasGroup menu, Action onComplete = null, bool hideOthers = true)
        {
            if (hideOthers)
            {
                foreach (var m in Menus)
                {
                    if (m != CurrentMenu)
                    {
                        m.gameObject.SetActive(false);
                    }
                }
            }
            
            AnimatedMenu animMenu = menu.gameObject.GetComponent<AnimatedMenu>();
            menu.gameObject.SetActive(true);
            CurrentMenu = menu;
            if (animMenu == null)
            {
                onComplete?.Invoke();
            }
            else
            {
                try
                {
                    animMenu.PlayShowAnimation(onComplete);
                }
                catch 
                {
                    // menu object was probably destroyed by a scene switch
                    onComplete?.Invoke();
                }
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