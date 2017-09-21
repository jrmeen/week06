using System;
using System.Net;  // for web client
using System.IO;   // for stream writer


namespace Labweek06
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0d;
            ask(ref weight);
            cal(ref weight);
            Console.WriteLine("Weight on Moon is : {0}", weight);
            Console.ReadKey();
        }
        static double ask(ref double weight)
        {
            Console.Write("Enter weight on Moon : ");
            weight = double.Parse(Console.ReadLine());
            return weight;

        }
        static double cal(ref double weight)
        {
            weight *= 1.6;
            return weight;
        }
    }
}