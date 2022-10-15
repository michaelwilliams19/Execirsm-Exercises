using System;

public static class Triangle
{
    //Dos posibles soluciones:

    //public static bool IsScalene(double side1, double side2, double side3) =>
    //    IsTriangle(side1, side2, side3) && !IsIsosceles(side1, side2, side3);

    //public static bool IsIsosceles(double side1, double side2, double side3)
    //    => IsTriangle(side1, side2, side3) && (side1 == side2 || side1 == side3 || side2 == side3);

    //public static bool IsEquilateral(double side1, double side2, double side3)
    //    => IsTriangle(side1, side2, side3) && side1 == side2 && side1 == side3;

    //private static bool IsTriangle(double side1, double side2, double side3) => (side1 > 0 && side2 > 0 && side3 > 0) &&
    //    (((side1 + side2) >= side3) && ((side2 + side3) >= side1) && ((side1 + side3) >= side2));

    public static bool IsScalene(double side1, double side2, double side3) => IsTriangle(side1, side2, side3) && GetListOfSides(side1, side2, side3).Distinct().Count() == 3;

    public static bool IsIsosceles(double side1, double side2, double side3) => IsTriangle(side1, side2, side3) && GetListOfSides(side1, side2, side3).Distinct().Count() != 3;

    public static bool IsEquilateral(double side1, double side2, double side3) => IsTriangle( side1, side2, side3) && GetListOfSides(side1, side2, side3).Distinct().Count() == 1;

    private static bool IsTriangle(double side1, double side2, double side3)
    {
        return GetListOfSides(side1, side2, side3).All(c => c > 0) &&
        (side1 + side2) >= side3 && (side2 + side3) >= side1 && (side1 + side3) >= side2;
    }

    private static List<double> GetListOfSides(double side1, double side2, double side3) => new List<double> { side1, side2, side3 };
}