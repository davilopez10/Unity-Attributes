using UnityEngine;


namespace Core.Attributes
{
    /// <summary>
    /// Add a button to the inspector. You cannot add it over array[], list, etc
    /// </summary>
    public class ButtonAttribute : PropertyAttribute
    {
        public string functionName;
        public int size;
        public object[] parameters;

        public ButtonAttribute(string functionName,int buttonSize = 20, params object[] parameters)
        {
            this.functionName = functionName;
            this.parameters = parameters;
            size = buttonSize;
        }

    }
}


