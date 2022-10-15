using System;
using System.Linq;

public static class Bob
{
    private static string ResponseSure = "Sure.";
    private static string ResponseYelling = "Whoa, chill out!";  
    private static string ResponseQuestion = "Calm down, I know what I'm doing!";  
    private static string ResponseEmpty = "Fine. Be that way!";  
    private static string ResponseWhatever = "Whatever.";

    public static string Response(string statement)
    {
        if (statement.IsSilence())
        {
            return ResponseEmpty;
        }
        else if (statement.IsQuestion() && !statement.IsYelling())
        {
            return ResponseSure;
        }
        else if (statement.IsYelling())
        {
            return statement.IsQuestion() ? ResponseQuestion : ResponseYelling;
        }
        else
        {
            return ResponseWhatever;
        }
    }

    public static bool IsSilence(this string statement) => string.IsNullOrEmpty(statement) || string.IsNullOrWhiteSpace(statement);
    public static bool IsQuestion(this string statement) => statement.Trim().EndsWith('?');
    public static bool IsYelling(this string statement) => statement.Any(char.IsLetter) && statement == statement.ToUpperInvariant();
}