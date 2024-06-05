using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class InputManager : MonoBehaviour
{
    private static List<InputDevice> rightHandInputDevices = new List<InputDevice>();
    public static bool TriggerPressed = false;
    public static bool PrimaryPressed = false;
    public static Vector2 Primary2DAxis;

    private void Start()
    {
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightHandInputDevices);
    }

    void FixedUpdate()
    {
        if (rightHandInputDevices.Count == 0)
            return;

        foreach (var device in rightHandInputDevices)
        {
            device.TryGetFeatureValue(CommonUsages.triggerButton, out TriggerPressed);
            device.TryGetFeatureValue(CommonUsages.primaryButton, out PrimaryPressed);
            device.TryGetFeatureValue(CommonUsages.primary2DAxis, out Primary2DAxis);
        }
    }
}
