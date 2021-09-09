using System;

namespace _2D_Arrays_ForLoops
{
    
    static int[,] matrix =
    {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };
    
    static void Main(string[] args)
    {
        foreach (int item in matrix)
        {
            Console.Write(item + " ");
        }
        
        Console.WriteLine("\n This is our 2D array printed using nested for loop");
        //Nested for loop
        //Outer for loop
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            //Inner for loop
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                //Modulo operator (%) works with remainders, if the remainder (number in paranthesis) is 1, then its an odd number
                if (matrix[i,j] % 2 == 0)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                else
                    Console.Write (" ");
                /*
                //Print diagonal (1, 5, 9)
                if (i == j)
                {
                    Console.Write(matrix[i,j] + " ");                    
                }
                else
                    Console.Write(" ");
                    
                Console.Write(matrix[i, j] + " ");
                */
            }            
        }
    }
}