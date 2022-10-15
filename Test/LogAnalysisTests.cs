using NUnit.Framework;
using System;
public class LogAnalysisTests
{
    [Test]
    public void SubstringAfter_WithDelimeterOfLength1()
    {
        Assert.AreEqual(" am the 1st test", "I am the 1st test".SubstringAfter("I"));
    }

    [Test]
    public void SubstringAfter_WithDelimeterOfLengthLongerThan1()
    {
        Assert.AreEqual(" test", "I am the 2nd test".SubstringAfter("2nd"));
    }

    [Test]
    public void SubstringBetween()
    {
        Assert.AreEqual("INFO", "[INFO]: File Deleted.".SubstringBetween("[", "]"));
    }

    [Test]
    public void SubstringBetweenLongerDelimiters()
    {
        Assert.AreEqual("SOMETHING", "FIND >>> SOMETHING <===< HERE".SubstringBetween(">>> ", " <===<"));
    }
    
    [Test]
    public void Message()
    {
        var log = "[WARNING]: Library is deprecated.";
        Assert.AreEqual("Library is deprecated.", log.Message());
    }

    [Test]
    public void LogLevel()
    {
        var log = "[WARNING]: Library is deprecated.";
        Assert.AreEqual("WARNING", log.LogLevel()); ;
    }
}
