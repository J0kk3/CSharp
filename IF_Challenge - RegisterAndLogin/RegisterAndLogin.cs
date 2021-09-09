using System;

namespace IfChallengeRAL
{
    class RegisterAndLogin
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        static void Register()
        {
            Console.WriteLine("Please enter your username...");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password...");
            password = Console.ReadLine();
            Console.WriteLine("Registration Completed!");
            Console.WriteLine("------------------------------");
        }

        static void Login()
        {
            Console.WriteLine("Please enter your username...");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password...");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful!");
                }
                else
                {
                Console.WriteLine("Login failed, wrong password. Restart Program.");
                }
            }
            else
            {
            Console.WriteLine("Login failed, wrong username. Restart Program.");
            }            
        }        
    }    
}