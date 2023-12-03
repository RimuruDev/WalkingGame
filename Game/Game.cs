using WalkerGame.Models;
using System.Diagnostics.CodeAnalysis;

namespace WalkerGame;

[SuppressMessage("ReSharper", "StringLiteralTypo")]
[SuppressMessage("ReSharper", "MemberCanBeMadeStatic.Local")]
public sealed class Game
{
    private readonly GameSettings settings;
    private readonly Random random = new();
    private readonly List<Player> players;
    private readonly List<Trap> traps;

    public Game(GameSettings settings)
    {
        this.settings = settings;
        players = CreatePlayers(settings.PlayersCount);
        traps = GenerateTraps(settings.MaxMapSize, settings.TrapsCount);
    }

    public void Start()
    {
        while (true)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Очередь игрока: {player.Name}");
                Console.ReadKey(true);

                var stepCount = random.Next(settings.PlayerStepsRange.X, settings.PlayerStepsRange.Y);
                player.Move(stepCount, settings.MaxMapSize);

                Console.WriteLine($"Игрок {player.Name} сделал {stepCount} шагов до {player.CurrentPosition}");

                var trap = traps.FirstOrDefault(t => t.IsTrapped(player));

                if (trap != null)
                {
                    player.Move(-trap.Punishment, settings.MaxMapSize);
                    Console.WriteLine(
                        $"Игрок {player.Name} попал в ловушку! Возврат на {trap.Punishment} шагов до {player.CurrentPosition}");
                }

                if (player.HasWon(settings.MaxMapSize))
                {
                    Console.WriteLine($"Игрок {player.Name} победил!");
                    return;
                }
            }
        }
    }

    private List<Player> CreatePlayers(int count)
    {
        var playerList = new List<Player>();

        for (var i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите имя игрока {i + 1}: ");

            var name = Console.ReadLine();
            playerList.Add(new Player(name));
        }

        return playerList;
    }

    private List<Trap> GenerateTraps(int mapSize, int count)
    {
        var trapPositions = new HashSet<int>();

        while (trapPositions.Count < count)
            trapPositions.Add(random.Next(1, mapSize));

        return trapPositions.Select(position =>
            new Trap(position, random.Next(settings.PunishmentRange.X, settings.PunishmentRange.Y))).ToList();
    }
}