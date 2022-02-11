using UnityEngine;
using Core.Attributes;
public class ExampleAttribute : MonoBehaviour
{
    [Button("TestFunction")]
    public Test testdefault;

    public bool condition;

    [Condition("condition")]
    public string ifCondition;

    [Condition("condition")]
    public string ifCondition2;

    [Condition("condition")]
    public string ifCondition3;

    [Condition("condition")]
    public string ifCondition4;

    [ColorBox(1,1,0,1)]
    public string finish;


    [System.Serializable]
    public class Test
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
 
}
