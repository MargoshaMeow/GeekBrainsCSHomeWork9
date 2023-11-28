// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class GeekBrainsHomework9
{
    // Задайте значение N. Напишите программу, коорая
    // выведет все натуральные числа в промежутке
    // от N до 1. Выполнить с помощью рекурсии.

    public static void task64(int n)
    {
        if (n >= 1) {
            Console.Write($"{n}");
            if (n > 1) {
                Console.Write($", ");
            }
            task64(n - 1);
        }
    }
    
    // Задайте значения M и N. Напишите программу
    // которая найдёт сумму натуральных элементов в
    // промежутке от M до N.
    public static int task66(int m, int n)
    {
        return m <= n ? task66(m, n - 1) + n : 0;
    }
    
    // Напишите программу вычисления функции
    // Аккермана с помощью рекурсии. Даны два
    // неотрицательных числа m и n.
    public static int task68(int m, int n)
    {
        if (m == 0) {
            return n + 1;
        }
        if (n == 0) {
            return task68(m - 1, 1);
        }
        return task68(m - 1, task68(m, n - 1));
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Task 64\nN = 5 -> ");
        task64(5);
        Console.Write("\nN = 8 -> ");
        task64(8);
        
        Console.WriteLine("\n\nTask 66");
        Console.WriteLine($"M = 1; N = 15 -> {task66(1,15)}");
        Console.WriteLine($"M = 4; N = 8 -> {task66(4,8)}");
        
        Console.WriteLine("\n\nTask 68");
        Console.WriteLine($"m = 2, n = 3 -> A(m,n) = {task68(2,3)}");
        Console.WriteLine($"m = 3, n = 2 -> A(m,n) = {task68(3,2)}");
    }
}
