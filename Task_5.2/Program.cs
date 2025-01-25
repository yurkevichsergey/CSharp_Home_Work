double result, correct_number_1;
Console.WriteLine("Enter the number:");
string? number_1 = Console.ReadLine();

try
{
    correct_number_1 = double.Parse(number_1);
    Console.WriteLine($"\nYour number is correct!");
}
catch (Exception)
{
    Console.WriteLine("\nInvalid enter. Please enter the numbers, not symbols");
}
finally
{
    Console.WriteLine("\nDone");
}
