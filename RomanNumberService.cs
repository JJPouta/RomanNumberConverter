using System;

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
                    int num = cnv.GetArabicNumber(res.ToUpper());
                    if(num > 0)
                    {
                        Console.WriteLine("Antamasi roomalaisen numeron int vastine on:");
                        Console.WriteLine(num);
                        return true;
                    }
                    else
                    {
                       Console.WriteLine("Numeroformaatissa havaittu virhe. Yritä uudelleen");
                       return true;
                    }
            }
        }
    }
}
