namespace GodotSteam;

public static partial class Steam
{
    public static void ActivateActionSet(ulong inputHandle, ulong actionSetHandle)
    {
        GetInstance().Call(Methods.ActivateActionSet, inputHandle, actionSetHandle);
    }
    
    public static void ActivateActionSetLayer(ulong inputHandle, ulong actionSetLayerHandle)
    {
        GetInstance().Call(Methods.ActivateActionSetLayer, inputHandle, actionSetLayerHandle);
    }
    
    public static void DeactivateActionSetLayer(ulong inputHandle, ulong actionSetHandle)
    {
        GetInstance().Call(Methods.DeactivateActionSetLayer, inputHandle, actionSetHandle);
    }
    
    public static void DeactivateAllActionSetLayers(ulong inputHandle)
    {
        GetInstance().Call(Methods.DeactivateAllActionSetLayers, inputHandle);
    }
    
    public static ulong GetActionSetHandle(string actionSetName)
    {
        return GetInstance().Call(Methods.GetActionSetHandle, actionSetName).AsUInt64();
    }
    
    public static InputActionOrigin GetActionOriginFromXboxOrigin(ulong inputHandle, int origin)
    {
        return (InputActionOrigin)GetInstance().Call(Methods.GetActionOriginFromXboxOrigin, inputHandle, origin).AsInt64();
    }
    
    public static Godot.Collections.Array GetActiveActionSetLayers(long inputHandle)
    {
        return GetInstance().Call(Methods.GetActiveActionSetLayers, inputHandle).AsGodotArray();
    }
    
    public static Godot.Collections.Dictionary GetAnalogActionData(ulong inputHandle, ulong analogActionHandle)
    {
        return GetInstance().Call(Methods.GetAnalogActionData, inputHandle, analogActionHandle).AsGodotDictionary();
    }
    
    public static ulong GetAnalogActionHandle(string actionName)
    {
        return GetInstance().Call(Methods.GetAnalogActionHandle, actionName).AsUInt16();
    }
    
    public static Godot.Collections.Array<int> GetAnalogActionOrigins(ulong inputHandle, ulong actionSetHandle, ulong analogActionHandle)
    {
        return GetInstance().Call(Methods.GetAnalogActionOrigins, inputHandle, actionSetHandle, analogActionHandle).AsGodotArray<int>();
    }
    
    public static Godot.Collections.Array<ulong> GetConnectedControllers()
    {
        return GetInstance().Call(Methods.GetConnectedControllers).AsGodotArray<ulong>();
    }
    
    public static ulong GetControllerForGamepadIndex(int index)
    {
        return GetInstance().Call(Methods.GetControllerForGamepadIndex, index).AsUInt16();
    }
    
    public static ulong GetCurrentActionSet(ulong inputHandle)
    {
        return GetInstance().Call(Methods.GetCurrentActionSet, inputHandle).AsUInt16();
    }

    //  [0] => Major | [0] => Minor
    public static Godot.Collections.Array<int> GetDeviceBindingRevision(ulong inputHandle)
    {
        return GetInstance().Call(Methods.GetDeviceBindingRevision, inputHandle).AsGodotArray<int>();
    }
    
    // state => bool | active => bool
    public static Godot.Collections.Dictionary GetDigitalActionData(ulong inputHandle, ulong digitalActionHandle)
    {
        return GetInstance().Call(Methods.GetDigitalActionData, inputHandle, digitalActionHandle).AsGodotDictionary();
    }
    
    public static ulong GetDigitalActionHandle(string actionName)
    {
        return GetInstance().Call(Methods.GetDigitalActionHandle, actionName).AsUInt64();
    }
    
    public static Godot.Collections.Array<int> GetDigitalActionOrigins(ulong inputHandle, ulong actionSetHandle, ulong digitalActionHandle)
    {
        return GetInstance().Call(Methods.GetDigitalActionOrigins, inputHandle, actionSetHandle, digitalActionHandle).AsGodotArray<int>();
    }
    
    public static int GetGamepadIndexForController(ulong inputHandle)
    {
        return GetInstance().Call(Methods.GetGamepadIndexForController, inputHandle).AsInt32();
    }
    
    public static string GetGlyphForActionOrigin(InputActionOrigin origin)
    {
        return GetInstance().Call(Methods.GetGlyphForActionOrigin, (long)origin).AsString();
    }
    
    public static string GetInputTypeForHandle(ulong inputHandle)
    {
        return GetInstance().Call(Methods.GetInputTypeForHandle, inputHandle).AsString();
    }
    
    public static ControllerMotionData GetMotionData(ulong inputHandle)
    {
        var raw =  GetInstance().Call(Methods.GetMotionData, inputHandle).AsGodotDictionary();

        if (!raw.ContainsKey("rot_quat_x"))
            return new();
        return new()
        {
            rotQuatX = raw["rot_quat_x"].AsSingle(),
            rotQuatY = raw["rot_quat_y"].AsSingle(),
            rotQuatZ = raw["rot_quat_z"].AsSingle(),
            rotQuatW = raw["rot_quat_w"].AsSingle(),
            posAccelX = raw["pos_accel_x"].AsSingle(),
            posAccelY = raw["pos_accel_y"].AsSingle(),
            posAccelZ = raw["pos_accel_z"].AsSingle(),
            rotVelX = raw["rot_vel_x"].AsSingle(),
            rotVelY = raw["rot_vel_y"].AsSingle(),
            rotVelZ = raw["rot_vel_z"].AsSingle(),
        };     
    }
    
    public static int GetRemotePlaySessionID(ulong inputHandle)
    {
        return GetInstance().Call(Methods.GetRemotePlaySessionID, inputHandle).AsInt32();
    }
    
    public static string GetStringForActionOrigin(InputActionOrigin origin)
    {
        return GetInstance().Call(Methods.GetStringForActionOrigin, (long)origin).AsString();
    }
    
    public static bool InputInit(bool explicitlyCallRunframe = false)
    {
        return GetInstance().Call(Methods.InputInit, explicitlyCallRunframe).AsBool();
    }
    
    public static bool InputShutdown()
    {
        return GetInstance().Call(Methods.InputShutdown).AsBool();
    }
    
    public static void RunFrame(bool reservedValue = true)
    {
        GetInstance().Call(Methods.RunFrame, reservedValue);
    }
    
    public static void SetLEDColor(ulong inputHandle, int colorR, int colorG, int colorB, int flags)
    {
        GetInstance().Call(Methods.SetLEDColor, inputHandle, colorR, colorG, colorB, flags);
    }
    
    public static bool ShowBindingPanel(ulong inputHandle)
    {
        return GetInstance().Call(Methods.ShowBindingPanel, inputHandle).AsBool();
    }
    
    public static void StopAnalogActionMomentum(ulong inputHandle, ulong action)
    {
        GetInstance().Call(Methods.StopAnalogActionMomentum, inputHandle, action);
    }
    
    public static int TranslateActionOrigin(InputType destinationInput, InputActionOrigin sourceOrigin)
    {
        return GetInstance().Call(Methods.TranslateActionOrigin, (long)destinationInput, (long)sourceOrigin).AsInt32();
    }
    
    public static void TriggerHapticPulse(ulong inputHandle, int targetPad, int duration)
    {
        GetInstance().Call(Methods.TriggerHapticPulse, inputHandle, targetPad, duration);
    }
    
    public static void TriggerRepeatedHapticPulse(ulong inputHandle, int targetPad, int duration, int offset, int repeat, int flags)
    {
        GetInstance().Call(Methods.TriggerRepeatedHapticPulse, inputHandle, targetPad, duration, offset, repeat, flags);
    }
    
    public static void TriggerVibration(ulong inputHandle, ushort leftSpeed, ushort rightSpeed)
    {
        GetInstance().Call(Methods.TriggerVibration, inputHandle, leftSpeed, rightSpeed);
    }
    
    public static bool SetInputActionManifestFilePath(string manifestPath)
    {
        return GetInstance().Call(Methods.SetInputActionManifestFilePath, manifestPath).AsBool();
    }
    
    public static void SetDualSenseTriggerEffect(ulong inputHandle, int parameters, int triggerMask, ScePadTriggerEffectMode effectMode, int position, int amplitude, int frequency)
    {
        GetInstance().Call(Methods.SetDualSenseTriggerEffect, inputHandle, parameters, triggerMask, (long)effectMode, position, amplitude, frequency);
    }
    
    public static bool WaitForData(bool waitForever, uint timeout)
    {
        return GetInstance().Call(Methods.WaitForData, waitForever, timeout).AsBool();
    }
    
    public static bool NewDataAvailable()
    {
        return GetInstance().Call(Methods.NewDataAvailable).AsBool();
    }
    
    public static void EnableDeviceCallbacks()
    {
        GetInstance().Call(Methods.EnableDeviceCallbacks);
    }
    
    public static string GetGlyphPNGForActionOrigin(InputActionOrigin origin, InputGlyphSize size, uint flags)
    {
        return GetInstance().Call(Methods.GetGlyphPNGForActionOrigin, (long)origin, (long)size, flags).AsString();
    }
    
    public static string GetGlyphSVGForActionOrigin(InputActionOrigin origin, uint flags)
    {
        return GetInstance().Call(Methods.GetGlyphSVGForActionOrigin, (long)origin, flags).AsString();
    }
    
    public static void TriggerVibrationExtended(ulong inputHandle, ushort leftSpeed, ushort rightSpeed, ushort leftTriggerSpeed, ushort rightTriggerSpeed)
    {
        GetInstance().Call(Methods.TriggerVibrationExtended, inputHandle, leftSpeed, rightSpeed, leftTriggerSpeed, rightTriggerSpeed);
    }
    
    public static void TriggerSimpleHapticEvent(ulong inputHandle, int hapticLocation, byte intensity, string gainDb, byte otherIntensity, string otherGainDb)
    {
        GetInstance().Call(Methods.TriggerSimpleHapticEvent, inputHandle, hapticLocation, intensity, gainDb, otherIntensity, otherGainDb);
    }
    
    public static string GetStringForXboxOrigin(int origin)
    {
        return GetInstance().Call(Methods.GetStringForXboxOrigin, origin).AsString();
    }
    
    public static string GetGlyphForXboxOrigin(int origin)
    {
        return GetInstance().Call(Methods.GetGlyphForXboxOrigin, origin).AsString();
    }
    
    public static ushort GetSessionInputConfigurationSettings()
    {
        return GetInstance().Call(Methods.GetSessionInputConfigurationSettings).AsUInt16();
    }
    
    public static string GetStringForDigitalActionName(ulong actionHandle)
    {
        return GetInstance().Call(Methods.GetStringForDigitalActionName, actionHandle).AsString();
    }
    
    public static string GetStringForAnalogActionName(ulong actionHandle)
    {
        return GetInstance().Call(Methods.GetStringForAnalogActionName, actionHandle).AsString();
    }
}