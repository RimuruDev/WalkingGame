#pragma warning disable CS8618

public sealed class GameSettings
{
    public int MaxMapSize { get; init; }
    public int PlayersCount { get; init; }
    public int TrapsCount { get; init; }
    public Vector2Int PunishmentRange { get; init; }
    public Vector2Int PlayerStepsRange { get; init; }
}