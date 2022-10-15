using System;
using System.Linq;
using System.Collections.Generic;

public static class DifferenceOfSquares
{
    public static IEnumerable<int> GetNaturalNumbers(int max) => Enumerable.Range(1, max);

    public static int CalculateSquareOfAnyNumber(int value) => value * value;

    public static int CalculateSquareOfSum(int max) => CalculateSquareOfAnyNumber(GetNaturalNumbers(max).Sum());

    public static int CalculateSumOfSquares(int max) => GetNaturalNumbers(max).Sum(c => CalculateSquareOfAnyNumber(c));

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}