using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 3, 6, 5, 3, 5, 5, 4, 5, 4, 3, 2, 3, 6, 4 };
            int count = arr.Length;
            int max = arr[0];
            int min = arr[1];
            int force = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                force = max - min;
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(force);
        }
    }
}
    }
}
