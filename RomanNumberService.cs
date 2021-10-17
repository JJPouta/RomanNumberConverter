using System;
using System.Threading;

namespace RomanNumberConverter
{
    public class RomanNumberService
    {

        public bool RunService()
        {
            RomanConverter cnv = new RomanConverter();

            Console.WriteLine("Syötä roomalainen numero muunnosta varten. Näppäinyhdistelmällä Q + ENTER voit lopettaa ohjelman:");
            string res = Console.ReadLine();


            switch (res.ToUpper())
            {
                case "Q":
                    return false;
                default:
                    Console.WriteLine("Antamasi roomalaisen numeron int vastine on:");
                    Console.WriteLine(cnv.GetArabicNumber(res));
                    Thread.Sleep(2000);
                    Console.WriteLine("Haluatko muuntaa toisen numeron (K/E)?");
                    string res2 = Console.ReadLine();

                    switch (res2.ToUpper())
                    {
                        case "K":
                            return true;
                        case "E":
                            return false;
                        default:
                            Console.WriteLine("Tuntematon komento. Palataan alkuun.");
                            return true;
                    }

            }

            
         
        }
        

    }
}
