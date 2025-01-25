int result, correct_number_1, correct_number_2;
Console.WriteLine("Enter the first number:");
string? number_1 = Console.ReadLine();
Console.WriteLine("\nEnter the second number:");
string? number_2 = Console.ReadLine();

try
{
    correct_number_1 = int.Parse(number_1);
    correct_number_2 = int.Parse(number_2);
    result = correct_number_1 / correct_number_2;
    Console.WriteLine($"\nResult = {result}");
}
catch (System.DivideByZeroException)
{
    Console.WriteLine("\nDivision by Zero. Please enter second number not NULL");
}
catch (Exception)
{
    Console.WriteLine("\nInvalid enter. Please enter the numbers, not symbols");
}
finally
{
    Console.WriteLine("\nDone");
}
