public sealed class GameSettings
{
    public int MaxMapSize { get; set; }
    public int PlayersCount { get; set; }
    public int TrapsCount { get; set; }
    public Vector2Int PunishmentRange { get; set; }
    public Vector2Int PlayerStepsRange { get; set; }
}