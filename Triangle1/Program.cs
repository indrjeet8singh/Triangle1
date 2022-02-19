using System;

namespace Triangle1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         for(int i=1; i<=6; i++)
            {
               Console.Write(" ");
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
