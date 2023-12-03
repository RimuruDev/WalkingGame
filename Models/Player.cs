namespace WalkerGame.Models;

public sealed class Player
{
    public string? Name { get; }
    public int CurrentPosition { get; private set; }

    public Player(string? name) =>
        Name = name;

    public void Move(int steps, int mapSize)
    {
        CurrentPosition += steps;

        if (CurrentPosition < 0)
            CurrentPosition = 0;

        if (CurrentPosition > mapSize)
            CurrentPosition = mapSize;
    }

    public bool HasWon(int mapSize) =>
        CurrentPosition >= mapSize;
}