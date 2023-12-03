namespace WalkerGame.Models;

public sealed class Trap
{
    public int Punishment { get; }
    private int Position { get; }

    public Trap(int position, int punishment)
    {
        Position = position;
        Punishment = punishment;
    }

    public bool IsTrapped(Player player) =>
        player.CurrentPosition == Position;
}