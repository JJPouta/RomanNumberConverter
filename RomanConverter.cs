using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumberConverter
{
    public class RomanConverter
    {
        private static readonly Dictionary<string, int> romanLogic = InitLogic();
        private List<int> numbers;
        private int total = 0;

        private static Dictionary<string, int> InitLogic()
        {
            return new Dictionary<string, int>()
            {
                {"I",1 },{"V",5 },{"X",10 },{"L",50 }, {"C",100 },{"D",500 }, {"M",1000}
            };
        }



        private int ConvertNumber(string romanNumber)
        {

            return romanLogic.First(n => n.Key.Equals(romanNumber)).Value;

        }

        private void Xlogic()
        {
            int currNumber = numbers.Last();
            int prevNumber = 0;
            if (numbers.Count > 1)
            {
                prevNumber = numbers[numbers.Count - 2];
            }
            
            // Tarkastetaan formaatti IIX ei mahdollinen
            if(numbers.Count > 3)
            {


            }

            if(currNumber == prevNumber)
            {

                total = total + currNumber;

            }
            else if(currNumber > prevNumber)
            {

                total = total - prevNumber + currNumber - prevNumber;

            }
            else
            {
                total = total + currNumber;

            }

        }

        public int GetArabicNumber(string numberInput)
        {
            numbers = new List<int>();
            foreach (char c in numberInput)
            {
                int currNumber = ConvertNumber(Char.ToString(c));
                numbers.Add(currNumber);
                Xlogic();
            };

            return total;
        }
    }
}
