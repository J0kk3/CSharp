using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a few variables
            int age = 31;
            string name = "Alfonso";
            string job = "Developer";

            //1. String concatenation
            Console.WriteLine("String Concatenation");
            System.Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");
             
            //2. String formatting
            //String formatting uses index
            System.Console.WriteLine("String Formatting");
            System.Console.WriteLine("Hello my name is {0}, I an {1} years old. I'm a {2}", name, age, job);

            //3. String interpolation
            //String Interpolation uses $ at the start which will allow us to write our
            //variables like this {variableName}
            System.Console.WriteLine("String Interpolation");
            System.Console.WriteLine($"Hello my name is {name}, I am {age} years old. I'm a {job}!");

            //4. Verbatim strings
            //Verbatim strings start with @ and tells the compiler to take the string
            //literally and ignore any spaces and escape characters like \n (\n means linebreak)
            System.Console.WriteLine("Verbatim strings");
            System.Console.WriteLine(@"Lorem ipsom dolor sit amet");

            //Instead of using \\ to write file paths we can use verbatim strings to make it easier
            //If you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            System.Console.WriteLine(@"C:\user\Admin\Dog Pictures\Dog1\Super CoolDog.png");

            //With Verbatim strings even valid escape characters won't work
            System.Console.WriteLine(@"Muhaha \n you have no powers here!");
        }
    }
}