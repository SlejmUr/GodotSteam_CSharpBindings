namespace GodotSteam;

[System.Flags]
public enum InputConfigurationEnableType : long
{
    None = 0,
    Playstation = 1,
    Xbox = 2,
    Generic = 4,
    Switch = 8
}