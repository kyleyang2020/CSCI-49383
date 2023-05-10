using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRSound : MonoBehaviour
{
    public AudioClip footstepSound;
    public AudioSource audioSource;

    private Vector2 lastJoystickPosition;

    // Use this for initialization
    void Start()
    {
        audioSource.clip = footstepSound;
        lastJoystickPosition = InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 joystickValue) ? joystickValue : Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 joystickValue))
        {
            if (joystickValue.magnitude > 0.1f && lastJoystickPosition.magnitude > 0.1f)
            {
                // Play the footstep sound
                audioSource.Play();
            }

            lastJoystickPosition = joystickValue;
        }
    }
}
