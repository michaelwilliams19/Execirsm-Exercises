using NUnit.Framework;

public class LogLevelsTests
{
    [Test]
    public void Error_message()
    {
        Assert.AreEqual("Stack overflow", LogLine.Message("[ERROR]: Stack overflow"));
    }

    [Test]
    public void Warning_message()
    {
        Assert.AreEqual("Disk almost full", LogLine.Message("[WARNING]: Disk almost full"));
    }

    [Test]
    public void Info_message()
    {
        Assert.AreEqual("File moved", LogLine.Message("[INFO]: File moved"));
    }

    [Test]
    public void Message_with_leading_and_trailing_white_space()
    {
        Assert.AreEqual("Timezone not set", LogLine.Message("[WARNING]:   \tTimezone not set  \r\n"));
    }

    [Test]
    public void Error_log_level()
    {
        Assert.AreEqual("error", LogLine.LogLevel("[ERROR]: Disk full"));
    }

    [Test]
    public void Warning_log_level()
    {
        Assert.AreEqual("warning", LogLine.LogLevel("[WARNING]: Unsafe password"));
    }

    [Test]
    public void Info_log_level()
    {
        Assert.AreEqual("info", LogLine.LogLevel("[INFO]: Timezone changed"));
    }

    [Test]
    public void Error_reformat()
    {
        Assert.AreEqual("Segmentation fault (error)", LogLine.Reformat("[ERROR]: Segmentation fault"));
    }

    [Test]
    public void Warning_reformat()
    {
        Assert.AreEqual("Decreased performance (warning)", LogLine.Reformat("[WARNING]: Decreased performance"));
    }

    [Test]
    public void Info_reformat()
    {
        Assert.AreEqual("Disk defragmented (info)", LogLine.Reformat("[INFO]: Disk defragmented"));
    }

    [Test]
    public void Reformat_with_leading_and_trailing_white_space()
    {
        Assert.AreEqual("Corrupt disk (error)", LogLine.Reformat("[ERROR]: \t Corrupt disk\t \t \r\n"));
    }
}
