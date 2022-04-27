using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HasCondition : Conditional
{
    [SerializeField] private AITest ai;

    public override TaskStatus OnUpdate()
    {
        if (ai.isInitAI)
        {
            return TaskStatus.Running;
        }
        return TaskStatus.Failure;
    }
}
