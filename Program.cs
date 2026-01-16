using System;

namespace MyFirstCSharpApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[5];
            bool found= false;
            int index = -1;
           

            Console.WriteLine("Enter the numbers of array:");

            for (int i = 0; i < 5; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArray Elements:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Array : [" + Numbers[i] + "]");
            }

            Console.WriteLine("Enter you want search..");
            
                int Search = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < 5; i++)
            {
                if (Numbers[i] == Search)
                {
                    found = true;
                    index = i;
                    break;
                }
            }
                if (found)
                {
                    Console.WriteLine("Number found at index " + index);
                }
                else
                {
                    Console.WriteLine("Number not found");
                }
            
            
        }
    }
}
