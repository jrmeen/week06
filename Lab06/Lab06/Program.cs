using System;

class Program
{
    static void Main()
    {
        int num;
        Console.Write("Enter number:");
        num = int.Parse(Console.ReadLine());
        check(ref num);
        Console.WriteLine(num);
        Console.ReadLine();
    }
    static void check(ref int i)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else
            Console.WriteLine("Odd number");
    }

}

