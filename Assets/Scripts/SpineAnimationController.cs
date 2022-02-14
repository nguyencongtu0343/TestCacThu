using Spine;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpineAnimationController : MonoBehaviour
{
    SkeletonAnimation skeleton;

    private void Awake()
    {
        skeleton = GetComponent<SkeletonAnimation>();
    }

    void Start()
    {
        skeleton.state.Event += OnEvent;
    }

    private void OnEvent(TrackEntry trackEntry, Spine.Event e)
    {
        if (e.Data.Name == "attack event")
        {
            Debug.Log("ATTACK");
        }
    }

    void Update()
    {
        
    }
}
