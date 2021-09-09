using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Human rolf = new Human("Rolf", "Blooper", "Brown", 48);
            rolf.IntroduceMyself();

            Human richter = new Human("Richter", "Belmont", "Blue", 32);
            richter.IntroduceMyself();
             
            //No parameters (default constructor)
            Human basicHuman = new Human();
             
            Console.ReadKey();
        }
    }
}