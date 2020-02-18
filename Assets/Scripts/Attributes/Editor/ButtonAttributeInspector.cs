
using System.Reflection;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ButtonAttribute))]
public class ButtonAttributeInspector : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        ButtonAttribute button = attribute as ButtonAttribute;

        Object obj = property.serializedObject.targetObject;
        MethodInfo method = obj.GetType().GetMethod(button.functionName);

        if (GUI.Button(new Rect(position.x, position.y, position.width, position.height/2.5f), button.functionName))
        {
            method.Invoke(obj, null);
        }

        EditorGUI.PropertyField(new Rect(position.x, position.y + position.height / 2f, position.width, position.height/2.5f), 
            property, label);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label)*2.5f;
    }
}
