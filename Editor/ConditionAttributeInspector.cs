using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.Text.RegularExpressions;
using System;

namespace Core.Attributes
{
    [CustomPropertyDrawer(typeof(ConditionAttribute))]
    public class ConditionalAttributeInspector : PropertyDrawer
    {
        FieldInfo field;
        object objCache;
        bool isActive;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ConditionAttribute condition = attribute as ConditionAttribute;

            if (objCache == null)
            {
                objCache = property.GetTargetObjectOfProperty();

                if (objCache == null)
                {
                    objCache = property.serializedObject.targetObject;
                }
            }

            if (field == null)
            {
                field = fieldInfo.DeclaringType.GetField(condition.condition);
            }

            if (field != null)
            {
                object value = field.GetValue(objCache);

                if (value is bool)
                {
                    isActive = (bool)value;

                    if (isActive)
                    {
                        EditorGUI.PropertyField(position, property, label, true);
                    }
                }
            }
            else
            {
                Debug.LogError("[ConditionalAttribute] Condition not found");
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return isActive ? base.GetPropertyHeight(property, label) : 0;
        }
    }
}

