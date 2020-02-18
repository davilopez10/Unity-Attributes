using UnityEngine;

public class ExampleAttribute : MonoBehaviour
{
    [Button("TestFunction")]
    public string button;

    [OnlyReadable]
    public string onlyReadable;

    [ColorBox(1f, 0.4f, 1f, 1f)]
    public string color;

    public void TestFunction()
    {
        Debug.Log("Test");
    }
}
