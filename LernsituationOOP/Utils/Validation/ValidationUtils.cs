using LernsituationOOP.Utils.Validation;
using System;
using System.Text.RegularExpressions;

namespace LernsituationOOP.Utils.Validation
{
    public class ValidationUtils
    {
        //public static bool IsEmailValid(string email) => IsStringNotNullOrEmpty(email) && Regex.IsMatch(email, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");

        //public static bool IsStringANumber(string number) => IsStringNotNullOrEmpty(number) && Regex.IsMatch(number, @"^-?[0-9][0-9,\.]+$");

        //public static bool IsStringNotNullOrEmpty(string input) => !string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input);

        //public static bool IsReservierungDateVaild(DateTime von, DateTime bis) => von.Date < bis.Date;

        //public static bool IsOlderThan18(DateTime dateTime) => ValidationUtils.GetAge(dateTime) >= 18;

        //private static int GetAge(DateTime dateOfBirth)
        //{
        //    DateTime today = DateTime.Today;
        //    return ((today.Year * 100 + today.Month) * 100 + today.Day - ((dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day)) / 10000;
        //}
    }
}