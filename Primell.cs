/***********************************************************************************************
 * Übungsnr:        06                                     
 * Programmname:    PrimeNumbers                                  
 * Autor:           karlof002                               
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Gibt alle Primzahlen zwischen 1 und 10000 aus
 * ************************************************
*/
using System;
namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDivisible;
            int foundPrimeCounter = 1;
            //Zahl einlesen
            Console.WriteLine("Primzahlrechner!");

            Console.Write("   2 ");

            for (int numberToCheckIfPrime = 3; numberToCheckIfPrime <= 10000; numberToCheckIfPrime++)
            {
                isDivisible = false;
                //Schleife zur Ermittlung ob es einen Teiler größer 1 und kleiner der Zahl gibt -> dann keine Primzahl
               
                for (int divisor = 2; divisor < numberToCheckIfPrime; divisor++)
                {
                    if (numberToCheckIfPrime % divisor == 0)
                    {
                        isDivisible = true;
                        break;
                    }
                }

                //Ausgabe des Ergebnisses
                if (isDivisible == false)
                {
                    Console.Write("{0,4} ",numberToCheckIfPrime);
                    foundPrimeCounter++;
                    if (foundPrimeCounter%8==0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
