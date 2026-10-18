using System.Text.RegularExpressions;

namespace RefactoringLab.Collections;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string? value)
    {
        return !string.IsNullOrWhiteSpace(value)
            && Regex.IsMatch(value, @"^(?:01[0125][0-9]{8}|\+201[0125][0-9]{8})$");
    }

    public static bool IsValidEgyptianNationalId(this string? value)
    {
        return !string.IsNullOrWhiteSpace(value)
            && Regex.IsMatch(value, @"^[23][0-9]{13}$");
    }
}