using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers:");
            int[] arr = Console.ReadLine().Split(' ').Select(str=>int.Parse(str)).ToArray();
            int n = arr.Length;

            Console.WriteLine("Top integers in the array:");
            for (int i = 0; i < n; i++)
            {
                bool topint = true;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        topint = false;
                        break;
                    }
                }
                if (topint)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
