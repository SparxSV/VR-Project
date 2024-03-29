using System;

using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    [SerializeField] private InputActionProperty pinchAnimationAction;

    private void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        
        Debug.Log(triggerValue);
    }
}
