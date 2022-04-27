using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using UnityEngine.AI;
using NaughtyAttributes;

[System.Serializable]
public class SharedAI : SharedVariable<AITest>
{
    public static implicit operator SharedAI(AITest value)
    {
        return new SharedAI { Value = value }; 
    }
}

[System.Serializable]
public class AITest : MonoBehaviour
{
    protected NavMeshAgent agent;
    protected BehaviorTree behaviorTree;

    private bool isComplete1 = false;
    private bool isComplete2 = false;

    public bool isInitAI = false;

    [Button("InitAI")]
    public void InitAI()
    {
        agent = GetComponent<NavMeshAgent>();
        behaviorTree = GetComponent<BehaviorTree>();

        Debug.Log("AI Initialized");

        agent.enabled = true;
        behaviorTree.enabled = true;
    }

    public bool Has1()
    {
        return !check;
    }

    public bool Has2()
    {
        return check;
    }

    public void Action1()
    {
        Debug.Log("Skill 1");
        isComplete1 = true;
    }

    public void Action2()
    {
        Debug.Log("Skill 2");
        isComplete2 = true;
    }

    public bool HasComplete1()
    {
        isComplete2 = false;
        return isComplete1;
    }

    public bool HasComplete2()
    {
        isComplete1 = false;
        return isComplete2;
    }

    private bool check = false; 
    public void ChangeNum()
    {
        check = !check;
    }
}
