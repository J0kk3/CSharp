using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare jaggedArray. Example below: 3 arrays inside the array
            int[][] jaggedArray = new int [3][];
            
            //Declaration model #1
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            
            //Declaration model #2
            jaggedArray[0] = new int[] {2, 3, 5, 6, 11};
            jaggedArray[1] = new int[] {1, 2, 3};
            jaggedArray[2] = new int[] {13, 21};
            
            //Declaration model #3
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2, 3, 5, 6, 11},
                new int[] {1, 2, 3}
            };
            
            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray2[0][2]);
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)                
                {
                    Console.WriteLine("{0} ", jaggedArray2[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}