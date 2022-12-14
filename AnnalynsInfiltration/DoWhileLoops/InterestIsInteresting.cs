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
    Agarrar balance del aņo actual y sumarle el interes de ese aņo.
    Al agarrar el proximo balance, el saldo tiene que ser con el interes incluido asi el saldo de este nuevo aņo es mas grande.
        Por ej:
        Saldo       | Porcentaje interes | Saldo obtenido en el aņo con interes:
        200.75      |        0.5         |               201.75375    -> Saldo del 1er aņo
        201.75375   |        0.5         |               202.76251875 -> Saldo del 2do aņo
    Y asi sucesivamente hasta llegar al saldo deseado. Usar un contador para saber los aņos.
    */
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal nuevoBalance = balance;
        int cantidadAņosSaldoDeseado = 0;

        do
        {
            nuevoBalance = AnnualBalanceUpdate(nuevoBalance);
            cantidadAņosSaldoDeseado++;
        } while (nuevoBalance <= targetBalance);

        return cantidadAņosSaldoDeseado;
    }
}
