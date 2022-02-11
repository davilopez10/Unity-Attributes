using UnityEngine;

namespace Core.Attributes
{
    /// <summary>
    /// Create a header over the field and added a separation space.
    /// </summary>
    public class HeaderBoxAttribute : PropertyAttribute
    {
        public string headerText;
        public float separation;
        public Color color;

        public HeaderBoxAttribute(string headerText, float r = 1, float g = 1, float b = 1, float a = 1, float separation = 25f)
        {
            this.headerText = headerText;
            this.separation = separation;
            this.color = new Color(r, g, b, a);
        }
    }
}
