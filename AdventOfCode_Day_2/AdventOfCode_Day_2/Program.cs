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
            while (true)
            {
                string[] inputs = Console.ReadLine().Split();
                string command = inputs[0];
                int number = Int32.Parse(inputs[1]);
                if (command == "forward")
                {
                    forward = forward + number;
                }
                else if (command == "down")
                {
                    depth = depth + number;
                }
                else if (command == "up")
                {
                    depth = depth - number;
                }


                answer = forward * depth;
                Console.WriteLine("The answer is " + answer);
            }
        }
    }
}
