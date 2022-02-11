using UnityEngine;

namespace Core.Attributes
{
    /// <summary>
    /// The variable will be readonly in the inspector. 
    /// </summary>
    public class OnlyReadableAttribute : PropertyAttribute
    {
        public OnlyReadableAttribute()
        {
        }
    }
}
