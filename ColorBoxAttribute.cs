using UnityEngine;

namespace Core.Attributes
{
    /// <summary>
    /// Draw a color box in the inspector field and change the text color.
    /// </summary>
    public class ColorBoxAttribute : PropertyAttribute
    {
        public Color color;
        public ColorBoxAttribute(float r, float g, float b, float a)
        {
            this.color = new Color(r, g, b, a);
        }
    }
}
