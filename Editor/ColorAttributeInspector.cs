using UnityEngine;
using UnityEditor;

namespace Core.Attributes
{
    [CustomPropertyDrawer(typeof(ColorBoxAttribute))]
    public class ColorBoxAttributeInspector : PropertyDrawer
    {
        Color defaultColor;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ColorBoxAttribute attColor = attribute as ColorBoxAttribute;

            defaultColor = GUI.color;

            GUI.color = attColor.color;
            GUI.Box(position, label);
            EditorGUI.PropertyField(position, property, label, true);

            GUI.color = defaultColor;
        }
    }
}

