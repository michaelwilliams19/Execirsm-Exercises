using NUnit.Framework;

public class CarsAssembleTests
{
    [Test]
    public void Success_rate_for_speed_zero()
    {
        Assert.AreEqual(0.0, AssemblyLine.SuccessRate(0));
    }
    
    [Test]
    public void Success_rate_for_speed_one()
    {
        Assert.AreEqual(1.0, AssemblyLine.SuccessRate(1));
    }
    
    [Test]
    public void Success_rate_for_speed_four()
    {
        Assert.AreEqual(1.0, AssemblyLine.SuccessRate(4));
    }
    
    [Test]
    public void Success_rate_for_speed_five()
    {
        Assert.AreEqual(0.9, AssemblyLine.SuccessRate(5));
    }
    
    [Test]
    public void Success_rate_for_speed_nine()
    {
        Assert.AreEqual(0.8, AssemblyLine.SuccessRate(9));
    }
    
    [Test]
    public void Success_rate_for_speed_ten()
    {
        Assert.AreEqual(0.77, AssemblyLine.SuccessRate(10));
    }
    
    [Test]
    public void Production_rate_per_hour_for_speed_zero()
    {
        Assert.AreEqual(0.0, AssemblyLine.ProductionRatePerHour(0));
    }

    [Test]
    public void Production_rate_per_hour_for_speed_one()
    {
        Assert.AreEqual(221.0, AssemblyLine.ProductionRatePerHour(1));
    }

    [Test]
    public void Production_rate_per_hour_for_speed_four()
    {
        Assert.AreEqual(884.0, AssemblyLine.ProductionRatePerHour(4));
    }

    [Test]
    public void Production_rate_per_hour_for_speed_seven()
    {
        Assert.AreEqual(1392.3, AssemblyLine.ProductionRatePerHour(7));
    }

    [Test]
    public void Production_rate_per_hour_for_speed_nine()
    {
        Assert.AreEqual(1591.2, AssemblyLine.ProductionRatePerHour(9));
    }

    [Test]
    public void Production_rate_per_hour_for_speed_ten()
    {
        Assert.AreEqual(1701.7, AssemblyLine.ProductionRatePerHour(10));
    }

    [Test]
    public void Working_items_per_minute_for_speed_zero()
    {
        Assert.AreEqual(0, AssemblyLine.WorkingItemsPerMinute(0));
    }

    [Test]
    public void Working_items_per_minute_for_speed_one()
    {
        Assert.AreEqual(3, AssemblyLine.WorkingItemsPerMinute(1));
    }

    [Test]
    public void Working_items_per_minute_for_speed_five()
    {
        Assert.AreEqual(16, AssemblyLine.WorkingItemsPerMinute(5));
    }

    [Test]
    public void Working_items_per_minute_for_speed_eight()
    {
        Assert.AreEqual(26, AssemblyLine.WorkingItemsPerMinute(8));
    }
    [Test]
    public void Working_items_per_minute_for_speed_nine()
    {
        Assert.AreEqual(26, AssemblyLine.WorkingItemsPerMinute(9));
    }

    [Test]
    public void Working_items_per_minute_for_speed_ten()
    {
        Assert.AreEqual(28, AssemblyLine.WorkingItemsPerMinute(10));
    }
}
