using UnityEngine;
using UnityEditor;

namespace Attributes
{
    [CustomPropertyDrawer(typeof(HeaderBoxAttribute))]
    public class HeaderBoxAttributeInspector : DecoratorDrawer
    {
        public override void OnGUI(Rect position)
        {
            HeaderBoxAttribute header = attribute as HeaderBoxAttribute;

            GUI.color = header.color;
            GUI.Box(position, header.headerText);
            GUI.color = Color.white;
        }

        public override float GetHeight()
        {
            return base.GetHeight();
        }
    }
}