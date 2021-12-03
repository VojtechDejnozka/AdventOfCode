using System;
using System.Linq;

namespace AdventOfCode_Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int consumption;
            string gamma = "";
            string epsilon = "";
            int[] zeros = new int[12];
            int[] ones = new int[12];
            string[] values = new string[10000];
            int i = 0;
            int j = 0;
            while (true)
            {               
                values[i] = Console.ReadLine();  
                if (values[i] == "e")
                {
                    break;
                }
                while (j < 12)
                {
                    if (values[i][j].Equals('0'))
                    {
                        zeros[j]++;
                    }
                    else
                    {
                        ones[j]++;
                    }                                     
                    j++;
                }                    
                j = 0;
                i++;                
            }
            while (j < 12)
            {
                if (zeros[j] > ones[j])
                {
                    gamma = gamma + "0";
                    epsilon = epsilon + "1";
                }
                else
                {
                    gamma = gamma + "1";
                    epsilon = epsilon + "0";
                }
                j++;
            }
            
            Console.WriteLine(gamma);
            Console.WriteLine(epsilon); //converting done by copying these values and then multiplying by calc
        }
    }
}
