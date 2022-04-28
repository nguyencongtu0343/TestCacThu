using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Test : MonoBehaviour
{
    [ShowInInspector] public Dictionary<int, int> dicTest = new Dictionary<int, int>();

    [Button("Test1 abc")]
    private void Test1()
    {
        dicTest.Add(1, 1);
        dicTest.Add(2, 2);

    }

    private void Start()
    {
    }
}
