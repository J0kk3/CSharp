using System;

namespace JaggedArray
{
    class Program
    {
            static void Main(string[] args)
        {
            string[] joesFaimily = new string[]
            {
                "Martha", "Robert"
            };
            
            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Michael", "Fred"},
                new string[]{"Darkwing Duck", "Nea"},
                new string[]{"Dwight", "Oni"},
                joesFamily
            };
            
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[3][1], friendsAndFamily[2][1]);
            Console.ReadKey();
        }
    }    
}