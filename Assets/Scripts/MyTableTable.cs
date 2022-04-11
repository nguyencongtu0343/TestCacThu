using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTableTable
{
    [ShowInInspector] public Dictionary<int, MyTableEntity> Dictionary = new Dictionary<int, MyTableEntity>();

    public void GenDatabase()
    {
        Dictionary.Clear();

        MyTable.ForEachEntity(entity =>
        {
            if (entity != null)
            {
                MyTableEntity table = new MyTableEntity(entity);
                Dictionary.Add(table.Identity, table);
            }
        });
    }
}
