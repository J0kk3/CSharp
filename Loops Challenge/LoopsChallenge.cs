using System;

namespace LoopsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current ammount of entrues {0}", count);
                Cinsole.WriteLine("Please enter -1 once you are ready to calculate the average");
                 
                input = Console.ReadLine();

                if (input == "-1")
                {
                    Console.WriteLine("-----------------------------------");
                    //Calculate the average and let the teacher know
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average socre of your students is {0}", average);
                }

                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber > 21)
                {
                    total += currentNumber;
                }

                else
                {
                    if (!(input == ("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }

                count++;
            }
            Console.Read();
        }
    }    
}