using NUnit.Framework;

public class PhoneNumberAnalysisTests
{
    [Test]
    public void Analyze_non_fake_non_newyork()
    {
        Assert.AreEqual((false, false, "1234"), PhoneNumber.Analyze("631-502-1234"));
    }

    [Test]
    public void Analyze_fake_non_newyork()
    {
        Assert.AreEqual((false, true, "1234"), PhoneNumber.Analyze("631-555-1234"));
    }

    [Test]
    public void Analyze_non_fake_newyork()
    {
        Assert.AreEqual((true, false, "1234"), PhoneNumber.Analyze("212-502-1234"));
    }

    [Test]
    public void Analyze_fake_newyork()
    {
        Assert.AreEqual((true, true, "1234"), PhoneNumber.Analyze("212-555-1234"));
    }

    [Test]
    public void Analyze_fake_fake()
    {
        Assert.AreEqual((false, false, "1234"), PhoneNumber.Analyze("515-212-1234"));
    }

    [Test]
    public void Is_Fake_fake()
    {
        Assert.True(PhoneNumber.IsFake(PhoneNumber.Analyze("212-555-1234")));
    }

    [Test]
    public void Is_Fake_non_fake()
    {
        Assert.False(PhoneNumber.IsFake(PhoneNumber.Analyze("555-212-1234")));
    }
}
