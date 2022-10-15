using System;

public static class Darts
{
    const int radioCirculoExterior = 10;
    const int radioCirculoMedio = 5;
    const int radioCirculoInterior = 1;

    public static int Score(double x, double y)
    {
        //int h = 0;
        //int k = 0;

        double xPow = Math.Pow(x, 2);
        double yPow = Math.Pow(y, 2);
        double result = xPow + yPow;
        double distanciaAlRadioCirculo = Math.Sqrt(result);

        return distanciaAlRadioCirculo switch
        {
            <= radioCirculoInterior => 10,
            <= radioCirculoMedio => 5,
            <= radioCirculoExterior => 1,
            _ => 0
        };
    }
    /* 
     * Ecuación general para un circulo: (x - h)^2 + (y - k)^2 = r^2
     * donde r = circulo. 
     * donde h, k = coordenada del centro del circulo.
     * 
     * En este caso, el centro del circulo es (0, 0) por ende h,k = (0,0)
     * Reemplazamos valores:
     * (x - h )^2 + (y - k)^2 = r^2 
     * => x2 + y2 = r2
     * => x2 + y2 = 10^2
     * => x^2 + y^2 = 100 -> Si los valores que reemplazo en X e Y son igual a 100 quiere decir que esta dentro del circulo.
     * 
     * Si no son iguales, para saber si esta dentro o afuera del circulo entonces debo aplicar la formula de distancia para un punto y el centro de un circulo:
     * d = (raiz cuadrada de: (x - h)^2 + (y - k)^2
     * 
     * Si d es menor al radio entonces quiere decir que el punto se encuentra dentro del circulo.
     * Si d es mayor al radio entonces quiere decir que el punto se encuentra fuera del circulo.
   */
}
