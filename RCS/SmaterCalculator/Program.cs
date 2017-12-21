using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmaterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // izveodo kalkulatora objektu

            // paprasīt lietotājam ievadī ievadi
            Console.WriteLine("please enter darbība");
            string input = Console.ReadLine();

            // "1+5-4" skaits ir 6 simboli pēdējā simola pozīcija ir 4
            // "1+" xkaits ir 2 pēdējā pozīcija ir 1
            int result;
            int counter = 0;
            while (counter < input.Length)
            {
                char symbol = input[counter];
                if(symbol == '+')
                {
                    Console.WriteLine("plus");
                }
                else
                {
                    int number;
                    number = Int32.Parse(symbol.ToString());
                    Console.WriteLine("number" + number);

                }

                counter = counter = 1;
            }
            Console.ReadLine();
        }
    }
}
