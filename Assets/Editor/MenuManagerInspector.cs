using System.Collections.Generic;
using Games.Shared.Util.Menu;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(MenuManager), true)]
    public class MenuManagerInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var menuManager = (MenuManager)target;

            EditorGUILayout.Separator();
            GUILayout.Label("Development", EditorStyles.boldLabel);
            
            if (menuManager.Menus.Count > 0)
            {
                var menuOptions = new List<string>();
                var doNothingOption = "<Do Nothing>";
                foreach (var menu in menuManager.Menus)
                {
                    menuOptions.Add(menu.name);
                }
                menuOptions.Add(doNothingOption);
                
                menuManager.selectedEditorMenuIndex = EditorGUILayout.Popup("Editor Menu", menuManager.selectedEditorMenuIndex, menuOptions.ToArray());

                if (menuManager.selectedEditorMenuIndex >= menuManager.Menus.Count)
                {
                    // do nothing, the user is in charge of activate/deactivate (alt+shift+A)
                }
                else
                {
                    var selectedEditorMenu = menuManager.Menus[menuManager.selectedEditorMenuIndex];
                    foreach (var menu in menuManager.Menus)
                    {
                        menu.gameObject.SetActive(menu == selectedEditorMenu);
                    }
                }
            }

            if (GUILayout.Button("Auto Detect Child Menus (Canvas)"))
            {
                menuManager.Menus.Clear();
                foreach (var child in menuManager.gameObject.transform)
                {
                    if (child is Transform transform)
                    {
                        var childCg = transform.GetComponent<CanvasGroup>();
                        if (childCg)
                        {
                            menuManager.Menus.Add(childCg);
                        }
                    }
                }
            }
            
            serializedObject.ApplyModifiedProperties();
        }
    }
}