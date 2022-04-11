using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTableEntity
{
    public float speed;
    public int Identity;

    public MyTableEntity(MyTable entity)
    {
        speed = entity.Get<float>("speed");
        Identity = entity.Get<int>("Identity");
    }
}
