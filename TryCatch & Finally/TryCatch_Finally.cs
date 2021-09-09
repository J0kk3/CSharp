using System;

namespace TryCatchAndFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                 int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {                
                //throw;
                Console.WriteLine("Format exception, please enter a number next time.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow Exception, the number was too long or too short for an int32.");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)!");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }
            
            //int userInputAsInt = int.Parse(userInput);

            Console.ReadKey();
        }
    }    
}