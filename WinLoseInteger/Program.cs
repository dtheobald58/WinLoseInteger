using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLoseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumb;
            do
            {
                Console.WriteLine("Please enter an integer:");
                userNumb = int.Parse(Console.ReadLine());
                if (userNumb % 3 == 0)
                {
                    Console.WriteLine("YOU WON!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost :(");
                }
            } while (userNumb % 3 != 0);
        }
    }
}
