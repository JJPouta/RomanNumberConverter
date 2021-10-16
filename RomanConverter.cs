using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumberConverter
{
    public class RomanConverter
    {
        private static readonly Dictionary<string, int> romanLogic = InitLogic();
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

        private void Xlogic(int currNumber,int prevNumber)
        {

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
            
            int currNumber = 0;
            int prevNumber = 0;
            int i = 0;

            int strLen = numberInput.Length;

            foreach (char c in numberInput)
            {
                currNumber = ConvertNumber(Char.ToString(c));

                 Xlogic(currNumber, prevNumber);
                prevNumber = currNumber;
                i++;
            };

            return total;
        }
    }
}
