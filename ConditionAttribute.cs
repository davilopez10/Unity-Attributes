using UnityEngine;

namespace Core.Attributes
{
    /// <summary>
    /// Draw the field in the inspector only if the bool condition is true
    /// </summary>
    public class ConditionAttribute : PropertyAttribute
    {
        public string condition;
        public ConditionAttribute(string condition)
        {
            this.condition = condition;
        }
    }
}
