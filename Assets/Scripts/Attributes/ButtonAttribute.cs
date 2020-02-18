﻿using UnityEngine;

public class ButtonAttribute : PropertyAttribute
{
    public string functionName;

    public ButtonAttribute(string functionName)
    {
        this.functionName = functionName;
    }

}

