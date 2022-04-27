using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

namespace TGGameAI
{
    [TaskCategory("AITest")]
    public class Init : Action
    {
        [SerializeField] private AITest ai;
        [SerializeField] private SharedAI sharedAI;

        public override TaskStatus OnUpdate()
        {
            if (ai /*&& ai.isInitAI*/)
            {
                sharedAI.Value = ai;
                return TaskStatus.Success;
            }
            return TaskStatus.Failure;
        }

    }
}