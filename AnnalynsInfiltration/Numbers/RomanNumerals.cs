using System;
using System.Linq;

public static class RomanNumeralExtension
{
    public static string GetRomanValue(int value) =>
        value switch
        {
            >= 1000 => "M",
            >= 900 => "CM",
            >= 500 => "D",
            >= 400 => "CD",
            >= 100 => "C",
            >= 90 => "XC",
            >= 50 => "L",
            >= 40 => "XL",
            >= 10 => "X",
            9 => "IX",
            8 => "VIII",
            7 => "VII",
            6 => "VI",
            5 => "V",
            4 => "IV",
            3 => "III",
            2 => "II",
            1 => "I",
            _ => ""
        };

    public static int GetIntValueFromRomanValue(string value) =>
        value switch
        {
            "M" => 1000,
            "CM" => 900,
            "D" => 500,
            "CD" => 400,
            "C" => 100,
            "XC" => 90,
            "L" => 50,
            "XL" => 40,
            "X" => 10,
            "IX" => 9,
            "VIII" => 8,
            "VII" => 7,
            "VI" => 6,
            "V" => 5,
            "IV" => 4,
            "III" => 3,
            "II" => 2,
            "I" => 1,
            _ => 0
        };

    public static string ToRoman(this int value)
    {
        string strRoman = string.Empty;
        int[] arrayInt = GetArrayValueInt(value);

        for (int i = 0; i < arrayInt.Length; i++)
        {
            int numberPow = arrayInt[i] * (int)Math.Pow(10, arrayInt.Length - 1 - i);

            while (numberPow != 0)
            {
                string romanValue = GetRomanValue(numberPow);

                strRoman += romanValue;
                numberPow = numberPow - GetIntValueFromRomanValue(romanValue);
            }
        }

        return strRoman;
    }

    private static int[] GetArrayValueInt(int value) => value.ToString().Select(charDigit => int.Parse(charDigit.ToString())).ToArray();
}

/* Otra solucion mucho mas simple:
 *  public static string ToRoman(this int value)
    {
        if (value < 1) return string.Empty;            
        if (value >= 1000) return "M" + ToRoman(value - 1000);
        if (value >= 900) return "CM" + ToRoman(value - 900); 
        if (value >= 500) return "D" + ToRoman(value - 500);
        if (value >= 400) return "CD" + ToRoman(value - 400);
        if (value >= 100) return "C" + ToRoman(value - 100);            
        if (value >= 90) return "XC" + ToRoman(value - 90);
        if (value >= 50) return "L" + ToRoman(value - 50);
        if (value >= 40) return "XL" + ToRoman(value - 40);
        if (value >= 10) return "X" + ToRoman(value - 10);
        if (value >= 9) return "IX" + ToRoman(value - 9);
        if (value >= 5) return "V" + ToRoman(value - 5);
        if (value >= 4) return "IV" + ToRoman(value - 4);
        if (value >= 1) return "I" + ToRoman(value - 1);
        return string.Empty;
    }
 */