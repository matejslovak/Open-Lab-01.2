using System;

namespace Open_Lab_01._2
{
    class Program
    {
        public static int Sum(int fnum, int snum)
        {
            return (fnum + snum);
        }

        static void Main(string[] args)
        {
            int fnum;
            int snum;
            int sum;
            Console.WriteLine("Enter the first number");
            fnum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            snum = int.Parse(Console.ReadLine());

            sum = Sum(fnum, snum);
            Console.WriteLine($"Sum is { sum } ");

        }
    }
}
