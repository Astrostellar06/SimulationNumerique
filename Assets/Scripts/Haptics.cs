using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haptics : MonoBehaviour
{
    private List<UnityEngine.XR.InputDevice> devices = new List<UnityEngine.XR.InputDevice>();

    private void Start()
    {
        UnityEngine.XR.InputDevices.GetDevicesWithCharacteristics(UnityEngine.XR.InputDeviceCharacteristics.Right, devices);
    }
    void Update()
    {

        foreach (var device in devices)
        {
            UnityEngine.XR.HapticCapabilities capabilities;
            if (!device.TryGetHapticCapabilities(out capabilities) || !capabilities.supportsImpulse)
                continue;

            uint channel = 0;
            if (InputManager.Primary2DAxis.x > .5f && Math.Abs(InputManager.Primary2DAxis.y) < .1f)
                device.SendHapticImpulse(channel, .2f, .5f);
            if (InputManager.Primary2DAxis.y > .5f && Math.Abs(InputManager.Primary2DAxis.x) < .1f)
                device.SendHapticImpulse(channel, .4f, 1);
            if (InputManager.Primary2DAxis.x < -.5f && Math.Abs(InputManager.Primary2DAxis.y) < .1f)
                device.SendHapticImpulse(channel, .6f, 1.5f);
            if (InputManager.Primary2DAxis.y < -.5f && Math.Abs(InputManager.Primary2DAxis.x) < .1f)
                device.SendHapticImpulse(channel, .8f, 2);
        }
    }
}
