using NUnit.Framework;
using NUnit.Framework.Constraints;

public class RollTheDieTests
{
    [Test]
    public void RollDie()
    {
        var player = new Player();
        for (var i = 0; i < 100; i++)
        {
            Assert.AreEqual(player.RollDie(), 1, 18);
        }
    }

    [Test]
    public void GenerateSpellStrength()
    {
        var player = new Player();
        var strength = player.GenerateSpellStrength();
        Assert.That(strength, Is.GreaterThan(0.0).And.LessThan(100.0));
    }
}
