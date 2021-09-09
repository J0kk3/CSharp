using System;

namespace EnhancedIfStatement
{
    static void Main(string[] args)
    {
        /*Condition ? first_expression : second_expression;
        condition has to be either true or false
        The conditional operator is right - associative.
        The expression a ? b: c? d : e
        is evaluated as a ? b : (c ? d : e),
        not as (a? b : c) ? d: e.
        The conditional operator can't be overloaded.
        */

        int temperature = -5;
        string stateOfMatter;

        if (temperature < 0)
        {
            stateOfMatter = "Solid";
        }
        else 
        {
            stateOfMatter = "liquid";
        }            

            //In short:
            stateOfMatter = temperature < 0 ? "Solid" : "Liquid";

            stateOfMatter = temperature > 100 ? "Gas" : temperature < 0 ? "Solid" : "Liquid";
             
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.ReadKey();
    }
}