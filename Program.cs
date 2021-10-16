using System;

namespace RomanNumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            

            RomanConverter cnv = new RomanConverter();

            Console.WriteLine("Syötä roomalainen numero muunnosta varten:");
            string romanNumber = Console.ReadLine();
            Console.WriteLine("Antamasi roomalaisen numeron int vastine on:");
            Console.WriteLine(cnv.GetArabicNumber(romanNumber));
            Console.WriteLine("Paina näppäintä lopettaaksesi ohjelman");
            Console.ReadKey();

        }
    }
}
