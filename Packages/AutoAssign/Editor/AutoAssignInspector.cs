using System;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(AutoAssign), true)]
    public class AutoAssignInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            var targetMb = (MonoBehaviour)target;

            if (GUILayout.Button("Auto Assign"))
            {
                // check my components (Scripts)
                foreach (var scriptComponent in targetMb.GetComponents<Component>())
                {
                    // script is [AutoAssignable]
                    if (Attribute.IsDefined(scriptComponent.GetType(), typeof(AutoAssignable)))
                    {
                        Debug.Log(scriptComponent.name + " is AutoAssignable");
                        var autoFields = scriptComponent.GetType().GetFields().Where(
                            field => !field.GetCustomAttributes(typeof(ManualAssign)).Any()
                        ).ToList();

                        foreach (var field in autoFields)
                        {
                            if (!typeof(Component).IsAssignableFrom(field.FieldType)) continue;

                            bool wasMatched = false;
                            ForEachChildRecursive(targetMb.transform, (child, depth) =>
                            {
                                //Debug.Log($"{field.Name} ({field.FieldType}) <--> {child}");
                                var childFieldComponent = child.GetComponent(field.FieldType);
                                if (field.Name == child.name && childFieldComponent)
                                {
                                    Debug.Log($"AutoAssign: {scriptComponent.name}.{field.Name} = " +
                                              childFieldComponent);
                                    field.SetValue(scriptComponent, childFieldComponent);
                                    wasMatched = true;
                                }

                                return wasMatched;
                            });
                            if (!wasMatched)
                            {
                                field.SetValue(scriptComponent, null);
                            }
                        }
                    }
                }
            }
        }

        private void ForEachChildRecursive(Transform parent, Func<Transform, int, bool> func, int curDepth = 0)
        {
            foreach (var childObj in parent)
            {
                if (childObj is Transform child)
                {
                    var abort = func.Invoke(child, curDepth);
                    if (abort)
                    {
                        return;
                    }

                    if (child.childCount > 0)
                    {
                        ForEachChildRecursive(child, func, curDepth++);
                    }
                }
            }
        }
    }
}