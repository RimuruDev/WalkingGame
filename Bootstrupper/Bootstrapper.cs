using WalkerGame;

public sealed class Bootstrapper
{
    public static void Main()
    {
        var settings = new GameSettings
        {
            PlayersCount = 2,
            MaxMapSize = 50,
            TrapsCount = 5,
            PunishmentRange = new Vector2Int(3, 8),
            PlayerStepsRange = new Vector2Int(1, 7)
        };

        var game = new Game(settings);
        game.Start();
    }
}