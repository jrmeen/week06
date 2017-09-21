using System;
using System.Net;  // for web client
using System.IO;   // for stream writer


namespace Labweek06
{
    class Program
    {
        static void Main(string[] args)
        {

            int height, long1, long2;
            Console.Write("Enter height : ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter long 1 : ");
            long1 = int.Parse(Console.ReadLine());
            Console.Write("Enter long 2 : ");
            long2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Area is : " + ans(height, long1, long2));
            Console.ReadKey();
        }
        static double ans(int height, int long1, int long2)
        {
            return (0.5 * (long1 + long2) * height);
        }
    }
}