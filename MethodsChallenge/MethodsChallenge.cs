using System;

namespace MethodsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {            
        string friend0 = "Bob";
        string friend1 = "George";
        string friend2 = "Peppa";

        GreetFriend(friend0);
        GreetFriend(friend1);
        GreetFriend(friend2);
        Console.Read();
        }

        static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + ", my friend!");
        }
    }    
}