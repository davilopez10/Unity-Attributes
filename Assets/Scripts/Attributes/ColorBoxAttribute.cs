using UnityEngine;

namespace Attributes
{
    public class ColorBoxAttribute : PropertyAttribute
    {
        public Color color;
        public ColorBoxAttribute(float r, float g, float b, float a)
        {
            this.color = new Color(r, g, b, a);
        }
    }
}
