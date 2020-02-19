using UnityEngine;

namespace Attributes
{
    public class ConditionAttribute : PropertyAttribute
    {
        public string condition;
        public ConditionAttribute(string condition)
        {
            this.condition = condition;
        }
    }
}
