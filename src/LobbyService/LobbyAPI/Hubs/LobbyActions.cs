﻿namespace LobbyAPI.Hubs;

public static class LobbyActions
{
    public const string UserJoined = "UserJoined";
    public const string AnonymousUserJoined = "AnonymousUserJoined";
    public const string OnDisconnect = "OnDisconnect";
    public const string OnConnect = "OnConnect";
    public const string MoviesChanged = "MoviesChanged";
    public const string UsersReadyStateChanged = "UsersReadyStateChanged";
    public const string RollEnded = "RollEnded";
}
