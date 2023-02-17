using System.Collections.Generic;
using Games.Shared.Util.Menu;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(MenuManager))]
    public class MenuManagerInspector : UnityEditor.Editor
    {
        private int selectedEditorMenuIndex = 0;
        
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var menuManager = (MenuManager)target;

            EditorGUILayout.Separator();
            GUILayout.Label("Development", EditorStyles.boldLabel);
            
            if (menuManager.Menus.Count > 0)
            {
                var menuOptions = new List<string>();
                foreach (var menu in menuManager.Menus)
                {
                    menuOptions.Add(menu.name);
                }
                
                selectedEditorMenuIndex = EditorGUILayout.Popup("Editor Menu", selectedEditorMenuIndex, menuOptions.ToArray());

                var selectedEditorMenu = menuManager.Menus[selectedEditorMenuIndex];
                foreach (var menu in menuManager.Menus)
                {
                    menu.gameObject.SetActive(menu == selectedEditorMenu);
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