using UnityEngine;
using UnityEditor;

namespace Attributes
{
    [CustomPropertyDrawer(typeof(ColorBoxAttribute))]
    public class ColorBoxAttributeInspector : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ColorBoxAttribute attColor = attribute as ColorBoxAttribute;

            Color tempColor = GUI.color;

            GUI.color = attColor.color;

            GUI.Box(position, label);

            EditorGUI.PropertyField(position, property, label);

            GUI.color = tempColor;
        }
    }
}

