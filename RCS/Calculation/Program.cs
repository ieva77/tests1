using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // izveodo kalkulēsanas objektu
            Calculations calc;
            calc = new Calculations();

            // paprasīt lietotājam vērtību
            int firstNumber = calc.AskUserForNumber();

            // paprasīt otra vērtība
            int secoundNumber = calc.AskUserForNumber();

            // saskaita
            int result = firstNumber + secoundNumber;
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
