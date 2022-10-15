using NUnit.Framework;

public class DartsTests
{
    [Test]
    public void Missed_target()
    {
        Assert.AreEqual(0, Darts.Score(-9, 9));
    }

    [Test]
    public void On_the_outer_circle()
    {
        Assert.AreEqual(1, Darts.Score(0, 10));
    }

    [Test]
    public void On_the_middle_circle()
    {
        Assert.AreEqual(5, Darts.Score(-5, 0));
    }

    [Test]
    public void On_the_inner_circle()
    {
        Assert.AreEqual(10, Darts.Score(0, -1));
    }

    [Test]
    public void Exactly_on_centre()
    {
        Assert.AreEqual(10, Darts.Score(0, 0));
    }

    [Test]
    public void Near_the_centre()
    {
        Assert.AreEqual(10, Darts.Score(-0.1, -0.1));
    }

    [Test]
    public void Just_within_the_inner_circle()
    {
        Assert.AreEqual(10, Darts.Score(0.7, 0.7));
    }

    [Test]
    public void Just_outside_the_inner_circle()
    {
        Assert.AreEqual(5, Darts.Score(0.8, -0.8));
    }

    [Test]
    public void Just_within_the_middle_circle()
    {
        Assert.AreEqual(5, Darts.Score(-3.5, 3.5));
    }

    [Test]
    public void Just_outside_the_middle_circle()
    {
        Assert.AreEqual(1, Darts.Score(-3.6, -3.6));
    }

    [Test]
    public void Just_within_the_outer_circle()
    {
        Assert.AreEqual(1, Darts.Score(-7, 7));
    }

    [Test]
    public void Just_outside_the_outer_circle()
    {
        Assert.AreEqual(0, Darts.Score(7.1, -7.1));
    }

    [Test]
    public void Asymmetric_position_between_the_inner_and_middle_circles()
    {
        Assert.AreEqual(5, Darts.Score(0.5, -4));
    }
}