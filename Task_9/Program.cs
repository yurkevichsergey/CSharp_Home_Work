/*Завдання 1.
 Написати програму, що знаходить другий найбільший елемент масиву.*/
using System;
using System.Diagnostics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Task #1:");
int[] array1 = new int[15];
Random rand_array1 = new Random();
Console.WriteLine("Generated unsorted array:");
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = rand_array1.Next(501);
    Console.WriteLine(array1[i]);
}
Console.WriteLine("\nSorted array:");
for (int i = 0;i < array1.Length; i++)
    for (int j = 0; j < array1.Length - 1; j++)
    {
        if(array1[j] > array1[j + 1])
        {
            array1[j + 1] += array1[j];
            array1[j] = array1[j + 1] - array1[j];
            array1[j + 1] -= array1[j];
        }
    }
foreach (int i in array1)
    Console.WriteLine(i);
Console.WriteLine($"The second maximum number in array = {array1[^2]}");

/*Завдання 2.
 Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.*/
Console.WriteLine("\n===========================================================================================");
Console.WriteLine("Task #2:");
int[,] array2 = new int[15, 15];
int rows2 = array2.GetLength(0);
int cols2 = array2.GetLength(1);
int[] one_line_array2 = new int[rows2 * cols2];
int index_one_line_array2 = 0;
Random rand_array2 = new Random();
Console.WriteLine("Generated unsorted array:");
for (int i = 0; i < 15; i++)
{
    for (int j = 0; j < 15; j++)
    {
        array2[i, j] = rand_array2.Next(501);
        Console.Write(array2[i, j] + "\t");
        one_line_array2[index_one_line_array2++] = array2[i, j];
    }
    Console.WriteLine();
}

for (int i = 0; i < one_line_array2.Length; i++)
    for (int j = 0; j < one_line_array2.Length - 1; j++)
    {
        if (one_line_array2[j] > one_line_array2[j + 1])
        {
            one_line_array2[j + 1] += one_line_array2[j];
            one_line_array2[j] = one_line_array2[j + 1] - one_line_array2[j];
            one_line_array2[j + 1] -= one_line_array2[j];
        }
    }
Console.WriteLine("\nSorted array:");
index_one_line_array2 = 0;
for (int i = 0; i < rows2; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        array2[i, j] = one_line_array2[index_one_line_array2++];
        Console.Write(array2[i, j] + "\t");
    }
    Console.WriteLine();
}



/*Завдання 3.
 Написати програму, що буде видаляти з масиву елемент за вказаним індексом.*/
Console.WriteLine("\n===========================================================================================");
Console.WriteLine("Task #3:");
int index = 15, delete_index = -1;
int[] entered_array3 = new int[index];
int[] deleted_array3 = new int[index - 1];
Random rand_array3 = new Random();
Console.WriteLine("Generated array with all elements:");
for (int i = 0; i < index; i++)
{
    entered_array3[i] = rand_array3.Next(501);
    Console.Write(entered_array3[i] + "\t");
}
do
{
    try
    {
        Console.WriteLine("\nEnter index of elements, which you want to delete from 0 - 14:");
        delete_index = int.Parse(Console.ReadLine());
    }
    catch (FormatException) 
    {
        Console.WriteLine("Invalid input, you entered symbols");
    }
} while (delete_index < 0 || delete_index > 15);

Console.WriteLine($"\nNew array without number of index {delete_index}, which was a number = {entered_array3[delete_index]}");
for (int i = 0, j = 0; i < index-1; i++, j++)
{
    if (j == delete_index)
    {
        j++;
    }
    deleted_array3[i] = entered_array3[j];
    Console.Write(deleted_array3[i] + "\t");
}


/*Завдання 4.
 Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.*/
Console.WriteLine("\n\n===========================================================================================");
Console.WriteLine("Task #4:");
int[,] new_array4 = new int[15, 15];
int sum_diagonal_array4 = 0;
Random rand_array4 = new Random();
Console.WriteLine("Random generated array:");
for (int i = 0; i < 15; i++)
{
    for (int j = 0; j < 15; j++)
    {
        new_array4[i, j] = rand_array4.Next(11);
        Console.Write(new_array4[i, j] + "\t");
        if(i == j)
        {
            sum_diagonal_array4 += new_array4[i, j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"\nSum of all diagonal elements = {sum_diagonal_array4}");
