using System;

namespace TernaryOperator
{
    class EnhancedIfChallenge
    {
        static void Main(string[] args)
        {
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            //Takes input from console
            Console.Write("Enter the current temperature : ");
            inputValue = Console.ReadLine();

            //Validate the input as valid input int value
            bool validInteger = int.TryParse(inputValue, out inputTemperature);

            if (validInteger)
            {
                //If is valid int, then it will check for the conditions using nes
                temperatureMessage = inputTemperature <= 15 ? "It is too cold here" : 
                (inputTemperature >= 16  && inputTemperature <= 28) ? "it is ok in here" : inputTemperature > 28 ? "It is nice and warm here" : "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                //In case if the input value is not a valid temperature
                Console.WriteLine("Not a valid temperature");
            }
            Console.ReadKey();
        }
    }    
}