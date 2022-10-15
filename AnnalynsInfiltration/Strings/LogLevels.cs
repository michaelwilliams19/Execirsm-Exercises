using System;

public static class LogLine
{
    public static string Message(string logLine)
    {
        string[] msj = logLine.Split(":");

        return msj[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] level = logLine.Split(":");
        return level[0].Trim().ToLower().Replace("[", "").Replace("]", "");
    }

    public static string Reformat(string logLine)
    {
        string[] mensajeDesestructurado = logLine.Split(":");
        string mensaje = mensajeDesestructurado[1].Trim();
        string level = mensajeDesestructurado[0].Trim().ToLower();
        level = level.Replace("[", "");
        level = level.Replace("]", "");

        return $"{mensaje} ({level})";
    }

}
