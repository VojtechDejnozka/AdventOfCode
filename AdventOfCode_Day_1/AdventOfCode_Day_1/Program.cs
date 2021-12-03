using System;

namespace AdventOfCode_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int increased = 0;
            int decreased = 0;
            int na = 0;
            int[] input = new int[10000];
            int i = 0;
            while (true)
            {
                string readLine = Console.ReadLine();
                int value = Int32.Parse(readLine);
                input[i] = value;
                if (i == 0)
                {
                    na++;
                }
                else if (input[i] > input[i - 1])
                {
                    increased++;                    
                }
                else if (input[i] < input [i-1])
                {
                    decreased++;
                }
                else
                {
                    na++;
                }
                Console.WriteLine("");
                Console.WriteLine(increased);
                i++;

            }
            
        }
    }
}
