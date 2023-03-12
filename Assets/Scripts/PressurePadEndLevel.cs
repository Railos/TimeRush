using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePadEndLevel : MonoBehaviour
{
    public Animator animator;
    public LayerMask mask;
    public UnityEvent OnPressed, OnReleased;

    private void Start()
    {
        OnReleased.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (( mask & (1 << other.gameObject.layer)) == 0) return;
        
        animator.SetBool("isPressed", true);
        OnPressed.Invoke();
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (( mask & (1 << other.gameObject.layer)) == 0) return;
        animator.SetBool("isPressed", false);
        OnReleased.Invoke();
    }
}
