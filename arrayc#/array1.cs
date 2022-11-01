using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 16 };
            int sum = 0;
            int max = arr[0];
            int min = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                    continue;
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                    continue;
                }
                Console.WriteLine(sum);
            }
        }
}
    }

