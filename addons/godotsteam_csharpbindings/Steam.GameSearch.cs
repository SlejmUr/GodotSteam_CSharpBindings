namespace GodotSteam;

public static partial class Steam
{
    
    public static GameSearchErrorCode AddGameSearchParams(string key, string values)
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.AddGameSearchParams, key, values).AsInt32();
    }
    
    public static GameSearchErrorCode SearchForGameWithLobby(ulong lobbyId, int playerMin, int playerMax)
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.SearchForGameWithLobby, lobbyId, playerMin, playerMax).AsInt32();
    }
    
    public static GameSearchErrorCode SearchForGameSolo(int playerMin, int playerMax)
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.SearchForGameSolo, playerMin, playerMax).AsInt32();
    }
    
    public static GameSearchErrorCode AcceptGame()
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.AcceptGame).AsInt32();
    }
    
    public static GameSearchErrorCode DeclineGame()
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.DeclineGame).AsInt32();
    }
    
    public static string RetrieveConnectionDetails(ulong hostId)
    {
        return GetInstance().Call(Methods.RetrieveConnectionDetails, hostId).AsString();
    }
    
    public static GameSearchErrorCode EndGameSearch()
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.EndGameSearch).AsInt32();
    }
    
    public static GameSearchErrorCode SetGameHostParams(string key, string value)
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.SetGameHostParams, key, value).AsInt32();
    }
    
    public static GameSearchErrorCode SetConnectionDetails(string details, int connectionDetails)
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.SetConnectionDetails, details, connectionDetails).AsInt32();
    }
    
    public static GameSearchErrorCode RequestPlayersForGame(int playerMin, int playerMax, int maxTeamSize)
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.RequestPlayersForGame, playerMin, playerMax, maxTeamSize).AsInt32();
    }
    
    public static GameSearchErrorCode HostConfirmGameStart(ulong gameId)
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.HostConfirmGameStart, gameId).AsInt32();
    }
    
    public static GameSearchErrorCode CancelRequestPlayersForGame()
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.CancelRequestPlayersForGame).AsInt32();
    }
    
    public static GameSearchErrorCode SubmitPlayerResult(ulong gameId, ulong playerId, PlayerResult playerResult)
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.SubmitPlayerResult, gameId, playerId, (int)playerResult).AsInt32();
    }
    
    public static GameSearchErrorCode EndGame(ulong gameId)
    {
        return (GameSearchErrorCode)GetInstance().Call(Methods.EndGame, gameId).AsInt32();
    }
}