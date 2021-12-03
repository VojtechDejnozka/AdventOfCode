using System;

namespace AdventOfCode_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            int forward = 0;
            int depth = 0;
            int aim = 0;
            while (true)
            {
                string[] inputs = Console.ReadLine().Split();
                string command = inputs[0];
                int number = Int32.Parse(inputs[1]);
                if (command == "forward")
                {
                    forward = forward + number;
                    depth = depth + (aim * number);
                }
                else if (command == "down")
                {                  
                    aim = aim + number;
                }
                else if (command == "up")
                {                    
                    aim = aim - number;
                }


                answer = forward * depth;
                Console.WriteLine("depth: " + depth);
                Console.WriteLine("forward: " + forward);
                Console.WriteLine("The answer is " + answer);
            }
        }
    }
}
