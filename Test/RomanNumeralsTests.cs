using NUnit.Framework;

public class RomanNumeralsTests
{
    [Test]
    public void Number_1_is_i()
    {
        Assert.AreEqual("I", 1.ToRoman());
    }

    [Test]
    public void Number_2_is_ii()
    {
        Assert.AreEqual("II", 2.ToRoman());
    }

    [Test]
    public void Number_3_is_iii()
    {
        Assert.AreEqual("III", 3.ToRoman());
    }

    [Test]
    public void Number_4_is_iv()
    {
        Assert.AreEqual("IV", 4.ToRoman());
    }

    [Test]
    public void Number_5_is_v()
    {
        Assert.AreEqual("V", 5.ToRoman());
    }

    [Test]
    public void Number_6_is_vi()
    {
        Assert.AreEqual("VI", 6.ToRoman());
    }

    [Test]
    public void Number_9_is_ix()
    {
        Assert.AreEqual("IX", 9.ToRoman());
    }

    [Test]
    public void Number_27_is_xxvii()
    {
        Assert.AreEqual("XXVII", 27.ToRoman());
    }

    [Test]
    public void Number_48_is_xlviii()
    {
        Assert.AreEqual("XLVIII", 48.ToRoman());
    }

    [Test]
    public void Number_49_is_xlix()
    {
        Assert.AreEqual("XLIX", 49.ToRoman());
    }

    [Test]
    public void Number_59_is_lix()
    {
        Assert.AreEqual("LIX", 59.ToRoman());
    }

    [Test]
    public void Number_93_is_xciii()
    {
        Assert.AreEqual("XCIII", 93.ToRoman());
    }

    [Test]
    public void Number_141_is_cxli()
    {
        Assert.AreEqual("CXLI", 141.ToRoman());
    }

    [Test]
    public void Number_163_is_clxiii()
    {
        Assert.AreEqual("CLXIII", 163.ToRoman());
    }

    [Test]
    public void Number_402_is_cdii()
    {
        Assert.AreEqual("CDII", 402.ToRoman());
    }

    [Test]
    public void Number_575_is_dlxxv()
    {
        Assert.AreEqual("DLXXV", 575.ToRoman());
    }

    [Test]
    public void Number_911_is_cmxi()
    {
        Assert.AreEqual("CMXI", 911.ToRoman());
    }

    [Test]
    public void Number_1024_is_mxxiv()
    {
        Assert.AreEqual("MXXIV", 1024.ToRoman());
    }

    [Test]
    public void Number_3000_is_mmm()
    {
        Assert.AreEqual("MMM", 3000.ToRoman());
    }
}