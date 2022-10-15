using System;

public static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idString = id.HasValue ? $"[{id}]": string.Empty;

        string departmentNotNull = (department ?? "OWNER").ToUpper();

        if (idString == string.Empty)
            return $"{name} - {departmentNotNull}";

        return $"{idString} - {name} - {departmentNotNull}";
    }
}
