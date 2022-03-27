using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_and_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----> Example of 'while loop' <----\n");
            int i = 1;
            int j;
            Console.Write("Enter umber of rows: ");
            j = Convert.ToInt32(Console.ReadLine());

            while (i <= j)
            {
                Console.WriteLine("Row number: " + i);
                i++;
            }
            
            Console.WriteLine("\n----> Example of 'do while loop' <----\n");
            int x = 1;
            int y;
            Console.Write("Enter umber of rows: ");
            y = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Row number: " + x);
                x++;
            }
            while (x <= y);


            Console.ReadLine();
        }
    }
}
