using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ColorBoxAttribute))]
public class ColorBoxAttributeInspector : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        ColorBoxAttribute attColor = attribute as ColorBoxAttribute;

        Color tempColor = GUI.color;

        GUI.color = attColor.color;

        GUI.BeginGroup(position, label);

        GUI.Box(new Rect(0, 0, position.width, position.height), label);

        GUI.EndGroup();

        EditorGUI.PropertyField(position, property, label);

        GUI.color = tempColor;
    }
}

