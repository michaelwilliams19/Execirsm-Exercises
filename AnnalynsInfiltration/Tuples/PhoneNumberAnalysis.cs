using System;
using System.Text.RegularExpressions;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string patron = "^\\d{3}-\\d{3}-\\d{4}$";
        bool isNewYork = false;
        bool isFake = false;
        string LocalNumber = "";

        if (Regex.Match(phoneNumber, patron).Success)
        {
            string[] phoneNumberSplit = phoneNumber.Split("-");

            isNewYork = phoneNumberSplit[0] == "212";
            isFake = phoneNumberSplit[1] == "555";
            LocalNumber = phoneNumberSplit[2];
        }
        
        return (isNewYork, isFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
