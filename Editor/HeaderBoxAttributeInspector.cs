using UnityEngine;
using UnityEditor;

namespace Core.Attributes
{
    [CustomPropertyDrawer(typeof(HeaderBoxAttribute))]
    public class HeaderBoxAttributeInspector : DecoratorDrawer
    {
        public override void OnGUI(Rect position)
        {
            HeaderBoxAttribute header = attribute as HeaderBoxAttribute;
            position.y += header.separation - 10f;
            GUI.color = Color.cyan;
            GUI.Box(position, header.headerText, EditorStyles.miniButtonMid);
            GUI.color = Color.white;
        }

        public override float GetHeight()
        {
            HeaderBoxAttribute header = attribute as HeaderBoxAttribute;
            return base.GetHeight() + header.separation;
        }
    }
}