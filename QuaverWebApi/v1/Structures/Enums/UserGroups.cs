using System;

namespace QuaverWebApi.v1.Structures.Enums;

[Flags]
public enum UserGroups
{
    /// <summary>
    ///     A normal user.
    /// </summary>
    Normal = 1 << 0,

    /// <summary>
    ///     An administrator of the server.
    /// </summary>
    Admin = 1 << 1,

    /// <summary>
    ///     A bot user for the server.
    /// </summary>
    Bot = 1 << 2,

    /// <summary>
    ///     A developer of the game.
    /// </summary>
    Developer = 1 << 3,

    /// <summary>
    ///     A moderator of the server
    /// </summary>
    Moderator = 1 << 4,

    /// <summary>
    ///     In charge of ranking maps on the game
    /// </summary>
    RankingSupervisor = 1 << 5,

    /// <summary>
    ///     God
    /// </summary>
    Swan = 1 << 6,

    /// <summary>
    ///     A contributor to the project.
    /// </summary>
    Contributor = 1 << 7,

    /// <summary>
    ///     A donator/backer of the project
    /// </summary>
    Donator = 1 << 8
}