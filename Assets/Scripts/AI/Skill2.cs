using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TGGameAI
{
    [TaskCategory("AITest")]
    public class Skill2 : Action
    {
        [SerializeField] private SharedAI sharedAI;

        public override TaskStatus OnUpdate()
        {
            var ai = sharedAI.Value;
            if (ai)
            {
                ai.Action2();
                return TaskStatus.Success;
            }
            return base.OnUpdate();
        }
    }
}
