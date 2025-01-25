double result, correct_number_1;
Console.WriteLine("Enter the number:");
string? number_1 = Console.ReadLine();

try
{
    correct_number_1 = double.Parse(number_1);
    Console.WriteLine($"\nYour number is correct!");
}
catch (FormatException)
{
    Console.WriteLine("Error, you enter not a number");
}
catch (Exception)
{
    Console.WriteLine("\nInvalid enter. Please enter the numbers");
}
finally
{
    Console.WriteLine("\nDone");
}
