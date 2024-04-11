namespace GodotSteam;

public class FriendGamePlayed
{
    public uint AppId { get; set; }
    public string Ip { get; set; }
    public ushort GamePort { get; set; }
    public ushort QueryPort { get; set; }
    public ulong Lobby { get; set; }
}