using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;

public class GameController : MonoBehaviour
{
    public MyTableTable myTable = new MyTableTable();

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        myTable.GenDatabase();
        Debug.Log(myTable.Dictionary.Count);
    }
}
