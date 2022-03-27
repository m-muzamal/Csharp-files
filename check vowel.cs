using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                char alphabet;
                Console.Write("\nEnter an alphabet: ");
                alphabet = Convert.ToChar(Console.ReadLine());

                switch (Char.ToLower(alphabet))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("Vowel");
                        break;
                    default:
                        Console.WriteLine("Not a vowel");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
