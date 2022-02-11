
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Core.Attributes
{
    [CustomPropertyDrawer(typeof(ButtonAttribute))]
    public class ButtonAttributeInspector : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ButtonAttribute button = attribute as ButtonAttribute;

            if (GUI.Button(new Rect(position.x, position.y, position.width, button.size), button.functionName))
            {
                object obj = property.GetTargetObjectOfProperty();
                MethodInfo method = obj.GetType().GetMethod(button.functionName);

                if (method != null)
                {
                    method.Invoke(obj, button.parameters);
                }
                else
                {
                    Debug.LogError("[ButtonAttribute] Method not found");
                }
            }

            EditorGUI.PropertyField(new Rect(position.x, position.y + button.size, position.width, position.height),
    property, label, true);

        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            ButtonAttribute button = attribute as ButtonAttribute;
            return button.size + EditorGUI.GetPropertyHeight(property, true);
        }
    }
}
