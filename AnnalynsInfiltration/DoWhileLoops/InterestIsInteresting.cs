using System;

public static class SavingsAccount
{
    public static float InterestRate(decimal balance) => Convert.ToSingle(balance switch
    {
        < 0 => 3.213F,
        < 1000 => 0.5F,
        < 5000 => 1.621F,
        >= 5000 => 2.475F,
    });

    public static decimal Interest(decimal balance) => balance * Convert.ToDecimal(InterestRate(balance)) / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    /*Para calcular el saldo deseado hay que:
    Agarrar balance del año actual y sumarle el interes de ese año.
    Al agarrar el proximo balance, el saldo tiene que ser con el interes incluido asi el saldo de este nuevo año es mas grande.
        Por ej:
        Saldo       | Porcentaje interes | Saldo obtenido en el año con interes:
        200.75      |        0.5         |               201.75375    -> Saldo del 1er año
        201.75375   |        0.5         |               202.76251875 -> Saldo del 2do año
    Y asi sucesivamente hasta llegar al saldo deseado. Usar un contador para saber los años.
    */
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal nuevoBalance = balance;
        int cantidadAñosSaldoDeseado = 0;

        do
        {
            nuevoBalance = AnnualBalanceUpdate(nuevoBalance);
            cantidadAñosSaldoDeseado++;
        } while (nuevoBalance <= targetBalance);

        return cantidadAñosSaldoDeseado;
    }
}
