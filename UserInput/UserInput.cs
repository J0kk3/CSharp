using system;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.Read();
            */
            Console.WriteLine(Calculate());
            Console.Read();
        }

        static int Calculate()
        {
            Console.WriteLine("Please enter the first number...");
            string number0Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number...");
            string number1Input = Console.ReadLine();
            
            int num0 = int.Parse(number0Input);
            int num1 = int.Parse(number1Input);
                         
            int result = num0 + num1;            
            return result;
        }
    }    
}