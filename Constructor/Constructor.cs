using System;

namespace Constructors
{
    class Human
    {
        //Member variable
        string firstName;
        string lastName;
        string eyeColor;
        int age;

        //Default Constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created.");
        }

        //Parameterized Constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }        

        //Member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}, and {2} years old. My eyecolor is {3}", firstName, lastName, age, eyeColor);
        }
    }    
}