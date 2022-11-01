using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 14, 16, 3, 7, 17, 19, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 4;
                if (i % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
