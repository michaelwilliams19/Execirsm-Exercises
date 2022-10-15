using System;

public class Player
{
    public int RollDie() => new Random().Next(0, 18);

    public double GenerateSpellStrength() => new Random().Next(0, 99);
}
