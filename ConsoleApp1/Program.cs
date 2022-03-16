using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number1 = { 5, 3, 4 };
            Console.WriteLine(HW1.QueueTime(number1, 1));
            int[] number2  = { 10, 2, 3, 3 };
            Console.WriteLine(HW1.QueueTime(number2, 2));
            int[] number3 = { 2, 3, 10 };
            Console.WriteLine(HW1.QueueTime(number3, 2));
        }
    }
}