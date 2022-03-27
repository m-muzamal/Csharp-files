using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mzml
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // right angle triangle
            Console.WriteLine("\nRight Angle Triangle");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            

            // right angle triangle inverse
            Console.WriteLine("\nRight angle triangle inverse");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }

            // triangle
            Console.WriteLine("\nTriangle");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            
            // triangle inverse
            Console.WriteLine("\nTriangle inverse");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= 5; k++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

            // square
            Console.WriteLine("\nSquare");

            for (int x = 1; x <= 5; x++)
            {
                for (int y = 1; y <= 5; y++)
                {
                    if (y == 1 || y == 5 || x == 1 || x == 5)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.Write("\n");
            }


            Console.ReadLine();
        }

    }
}
