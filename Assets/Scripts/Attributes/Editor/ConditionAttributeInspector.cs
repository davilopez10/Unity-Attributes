using UnityEngine;
using UnityEditor;
using System.Reflection;

namespace Attributes
{
    [CustomPropertyDrawer(typeof(ConditionAttribute))]
    public class ConditionalAttributeInspector : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ConditionAttribute condition = attribute as ConditionAttribute;

            Object obj = property.serializedObject.targetObject;
            FieldInfo field = obj.GetType().GetField(condition.condition);

            object value = field.GetValue(obj);

            if (value is bool)
            {
                bool active = (bool)value;

                if (active)
                {
                    EditorGUI.PropertyField(position, property, label);
                }
            }


        }
    }
}

