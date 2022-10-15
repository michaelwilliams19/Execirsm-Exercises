using NUnit.Framework;

public class TimFromMarketingTests
{
    [Test]
    public void Label_for_employee()
    {
        Assert.AreEqual("[17] - Ryder Herbert - MARKETING", Badge.Print(17, "Ryder Herbert", "Marketing"));
    }

    [Test]
    public void Label_for_new_employee()
    {
        Assert.AreEqual("Bogdan Rosario - MARKETING", Badge.Print(null, "Bogdan Rosario", "Marketing"));
    }

    [Test]
    public void Label_for_owner()
    {
        Assert.AreEqual("[59] - Julie Sokato - OWNER", Badge.Print(59, "Julie Sokato", null));
    }

    [Test]
    public void Label_for_new_owner()
    {
        Assert.AreEqual("Amare Osei - OWNER", Badge.Print(null, "Amare Osei", null));
    }
}
