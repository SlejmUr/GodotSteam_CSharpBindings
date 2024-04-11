namespace GodotSteam;

public enum GameSearchErrorCode
{
    OK = 1,
    Failed_Search_Already_In_Progress = 2,
    Failed_No_Search_In_Progress = 3,
    Failed_Not_Lobby_Leader = 4, // if not the lobby leader can not call SearchForGameWithLobby
    Failed_No_Host_Available = 5, // no host is available that matches those search params
    Failed_Search_Params_Invalid = 6, // search params are invalid
    Failed_Offline = 7, // offline, could not communicate with server
    Failed_NotAuthorized = 8, // either the user or the application does not have priveledges to do this
    Failed_Unknown_Error = 9, // unknown error
}