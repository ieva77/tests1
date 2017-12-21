using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Calculations
    {
        public int AskUserForNumber()
        {
            // izvadīt tekstu kas paprasa ciparu
            Console.WriteLine("please enter number");
            // ievadīt ciparu no konsoles
            // izveido mainīgo kas glabās tekstu
            int number;
            // ieraksta mainīgajā ReadLine funkcijas rezultātus
            string inputText = Console.ReadLine();

            // pārveido lietotāja tekstu par ciparu
            bool success = Int32.TryParse(inputText, out number);

            if (success == false)
            {
                Console.WriteLine("sorry, wrong value entered");
                number = this.AskUserForNumber();

            }

            return number;
        }
    }
}
