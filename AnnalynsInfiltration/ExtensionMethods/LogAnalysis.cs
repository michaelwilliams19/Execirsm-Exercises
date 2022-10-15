using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string text, string caracterToSplit)
    {
        string[] textoSplit = text.Split(caracterToSplit);
        return textoSplit[1];
    }

    public static string SubstringBetween(this string text, string initialCharacter, string finalCharacter)
    {
        int indexFirst = text.IndexOf(initialCharacter) + initialCharacter.Trim().Length;
        int indexLast = text.IndexOf(finalCharacter);

        string finalText = text.Substring(indexFirst, indexLast - indexFirst);

        string finalTextAnotherSolution = text.Split(finalCharacter).First().Split(initialCharacter).Last();

        return finalText.Trim();
    }

    public static string Message(this string text)
    {
        return text.SubstringAfter(":").Trim();
    }

    public static string LogLevel(this string text)
    {
        return text.SubstringBetween("[", "]").Trim();
    }
}