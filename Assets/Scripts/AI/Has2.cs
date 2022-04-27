using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TGGameAI
{
    [TaskCategory("AITest")]
    public class Has2 : HasCondition
    {
        [SerializeField] private SharedAI sharedAI;

        public override TaskStatus OnUpdate()
        {
            var ai = sharedAI.Value;
            if (ai && ai.Has2())
            {
                return TaskStatus.Success;
            }
            return base.OnUpdate();
        }
    }
}