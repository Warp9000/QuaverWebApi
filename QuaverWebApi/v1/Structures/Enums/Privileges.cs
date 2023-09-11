using System;

namespace QuaverWebApi.v1.Structures.Enums;

[Flags]
public enum Privileges
{
    /// <summary>
    ///     Normal server user, nothing special.
    /// </summary>
    Normal = 1 << 0,

    /// <summary>
    ///     The ability to kick users from the server.
    /// </summary>
    KickUsers = 1 << 1,

    /// <summary>
    ///     The ability to ban users from the game.
    /// </summary>
    BanUsers = 1 << 2,

    /// <summary>
    ///     The ability to send notifications to users in-game.
    /// </summary>
    NotifyUsers = 1 << 3,

    /// <summary>
    ///     The ability to mute users in-game.
    /// </summary>
    MuteUsers = 1 << 4,

    /// <summary>
    ///     The user has the ability to rank mapsets
    /// </summary>
    RankMapsets = 1 << 5,

    /// <summary>
    ///     The ability to view admin logs in the admin panel
    /// </summary>
    ViewAdminLogs = 1 << 6,

    /// <summary>
    ///     The ability to modify users
    /// </summary>
    EditUsers = 1 << 7,
    ManageBuilds = 1 << 8,
    ManageAlphaKeys = 1 << 9,
    ManageMapsets = 1 << 10,
    EnableTournamentMode = 1 << 11
}