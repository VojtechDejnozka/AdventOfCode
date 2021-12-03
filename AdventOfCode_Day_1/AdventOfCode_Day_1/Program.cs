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
            int temp = 0;
            int temp2 = 0;
            int[] input = new int[10000];
            int[] values = new int[3];
            int i = 0;
            int j = 0;
            while (true)
            {
                string readLine = Console.ReadLine();
                int value = Int32.Parse(readLine);                         
                input[i] = value;
                values[j] = input[i];
                if (i > 1)
                {
                    temp = values[0] + values[1] + values[2];
                    if (temp > temp2)
                    {
                        increased++;                       
                    }
                    temp2 = temp;
                }



                Console.WriteLine(increased);


                i++;
                if (j==2)
                {                   
                    j = 0;
                }
                else
                {
                    j++;
                }
            }
        }

    }
}
