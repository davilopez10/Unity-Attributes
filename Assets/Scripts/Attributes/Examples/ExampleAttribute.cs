using UnityEngine;
using Attributes;
public class ExampleAttribute : MonoBehaviour
{
    [Button("TestFunction")]
    public string button;

    [OnlyReadable]
    public string onlyReadable;

    [ColorBox(1f, 0.4f, 1f, 1f)]
    public string color;

    [HeaderBox("MY HEADER")]
    public string header;

    public bool condition;

    [Condition("condition")]
    public string ifCondition;

    public void TestFunction()
    {
        Debug.Log("Test");
    }
}
