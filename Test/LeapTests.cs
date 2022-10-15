using NUnit.Framework;

public class LeapTests
{
    [Test]
    public void Year_not_divisible_by_4_in_common_year()
    {
        Assert.False(Leap.IsLeapYear(2015));
    }

    [Test]
    public void Year_divisible_by_2_not_divisible_by_4_in_common_year()
    {
        Assert.False(Leap.IsLeapYear(1970));
    }

    [Test]
    public void Year_divisible_by_4_not_divisible_by_100_in_leap_year()
    {
        Assert.True(Leap.IsLeapYear(1996));
    }

    [Test]
    public void Year_divisible_by_4_and_5_is_still_a_leap_year()
    {
        Assert.True(Leap.IsLeapYear(1960));
    }

    [Test]
    public void Year_divisible_by_100_not_divisible_by_400_in_common_year()
    {
        Assert.False(Leap.IsLeapYear(2100));
    }

    [Test]
    public void Year_divisible_by_100_but_not_by_3_is_still_not_a_leap_year()
    {
        Assert.False(Leap.IsLeapYear(1900));
    }

    [Test]
    public void Year_divisible_by_400_is_leap_year()
    {
        Assert.True(Leap.IsLeapYear(2000));
    }

    [Test]
    public void Year_divisible_by_400_but_not_by_125_is_still_a_leap_year()
    {
        Assert.True(Leap.IsLeapYear(2400));
    }

    [Test]
    public void Year_divisible_by_200_not_divisible_by_400_in_common_year()
    {
        Assert.False(Leap.IsLeapYear(1800));
    }
}