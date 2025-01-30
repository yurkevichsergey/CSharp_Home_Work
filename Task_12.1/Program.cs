/* Завдання 12.1
Створіть окремий статичний клас. 
До нього треба додати рекурсивну функцію для обчислення числа Фібоначчі певного порядку.
Метод приймає номер числа і повертає число Фібоначчі вказаного номеру.
Вважати першим числом послідовності 0, другим — 1*/
using System;

public static class Fibonacci
{
    public static int CalculateFibonacci(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else if (n == 0)
        {
            return 0;
        }
        else
        {
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }
}

public class Program
{
    public static void Main()
    {
        int first_number = 3, second_number = 11, third_number = 10;
        Console.WriteLine($"Перше число Фiбоначчi {first_number} = {Fibonacci.CalculateFibonacci(first_number - 1)}");
        Console.WriteLine($"Друге число Фiбоначчi {second_number} = {Fibonacci.CalculateFibonacci(second_number - 1)}");
        Console.WriteLine($"Третє число Фiбоначчi {third_number} = {Fibonacci.CalculateFibonacci(third_number - 1)}");
    }
}
