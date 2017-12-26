using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmaterCalculator
{
    class MathParser
    {
        // funkcija kas saņem lietotāja ievadītu tekstu saparsē/konvertē/to un 
        // veic matemātiskās darības 
        // un atgriež rezulttu
        public int ParseMath(string input)
        {
            // "1+5-4" skaits ir 6 simboli pēdējā simola pozīcija ir 4
            // "1+" xkaits ir 2 pēdējā pozīcija ir 1
            int result;
            // izveido mainīgo kurā saglabā ievadīto ciparu tekstu
            string firstEnteredNumber = "";
            string secoundEnteredNumber = "";
            char enteredOperation = ' ';
            bool operationFound = false;
            int counter = 0;
            while (counter < input.Length)
            {
                char symbol = input[counter];
                if (symbol == '+')
                {
                    // saglabā operāciju mainīgajā
                    enteredOperation = symbol;
                    // ieliek karodziņu ka kad tiks pabeigts
                    // ielasīt nākošo skaitli, operācija ir jāizpilda
                    operationFound = true;
                }
                else
                {
                    // kad cipars ir atrasts
                    // ja operācija vel nav bijusi tad ierakstām vērtību
                    if (operationFound == false)
                    {
                        // pirmaja skaitlī
                        firstEnteredNumber = firstEnteredNumber + symbol;
                    }
                    else
                    {
                        // ja operācija ir bijusi
                        // ierakstām vērtību otrajā skaitlī
                        secoundEnteredNumber = secoundEnteredNumber + symbol;
                    }
                    // saglabā simolu teksta virknēlai tam
                    // var piekļūt, kad tiek veikta darbība
                    firstEnteredNumber = firstEnteredNumber + symbol;
                }

                counter = counter = 1;
            }
    }
}
