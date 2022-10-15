using System;

public static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed switch
    {
        < 1 => 0,
        <= 4 => 1,
        <= 8 => 0.9,
        9 => 0.8,
        10 => 0.77,
        _ => 0,
    };

    public static double ProductionRatePerHour(int speed) => speed * SuccessRate(speed) * 221;
 
    public static int WorkingItemsPerMinute(int speed) => Convert.ToInt32(ProductionRatePerHour(speed)) / 60;
    //Si se la tasa de exito por hora, entonces para saber por minuto hago el resultado dividido 60min.
}
