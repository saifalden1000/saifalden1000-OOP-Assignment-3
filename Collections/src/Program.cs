using RefactoringLab.Collections;

CheckPhone("01012345678", true);
CheckPhone("+201512345678", true);
CheckPhone("01312345678", false);
CheckPhone("0101234567", false);
CheckPhone("0101234567a", false);
CheckPhone(null, false);
CheckPhone("", false);
CheckPhone("   ", false);

CheckNationalId("29901011234567", true);
CheckNationalId("19901011234567", false);
CheckNationalId("2990101123456", false);
CheckNationalId(null, false);
CheckNationalId("", false);
CheckNationalId("   ", false);

void CheckPhone(string? value, bool expected)
{
    var actual = value.IsValidEgyptianPhone();
    Console.WriteLine($"Phone '{value ?? "null"}': {actual}, expected: {expected}");
}

void CheckNationalId(string? value, bool expected)
{
    var actual = value.IsValidEgyptianNationalId();
    Console.WriteLine($"National ID '{value ?? "null"}': {actual}, expected: {expected}");
}