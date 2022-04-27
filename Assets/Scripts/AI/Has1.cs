using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TGGameAI
{
    [TaskCategory("AITest")]
    public class Has1 : HasCondition
    {
        [SerializeField] private SharedAI sharedAI;

        public override TaskStatus OnUpdate()
        {
            var ai = sharedAI.Value;
            if (ai && ai.Has1())
            {
                return TaskStatus.Success;
            }
            return base.OnUpdate();
        }
    }
}