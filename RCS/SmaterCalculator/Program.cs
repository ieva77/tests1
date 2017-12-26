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
            MathParser parser;
            parser = new MathParser();
            // paprasīt lietotājam ievadī ievadi
            Console.WriteLine("please enter darbība");
            string input = Console.ReadLine();

            // izsauc aprēķināšanas funkciju un saglabā rezultātu
            int result = parser.ParseMath(input);
            // izvada rezultātu uz ekrāna
            Console.WriteLine("your result" + result);
            Console.ReadLine();
        }
    }
}
