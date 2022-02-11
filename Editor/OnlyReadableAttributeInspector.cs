﻿using UnityEngine;
using UnityEditor;

namespace Core.Attributes
{
    [CustomPropertyDrawer(typeof(OnlyReadableAttribute))]
    public class OnlyReadableInspector : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;

            EditorGUI.PropertyField(position, property, label, true);

            GUI.enabled = true;
        }
    }
}

