using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumberConverter
{
    public class RomanConverter
    {
        private readonly Dictionary<string, int> romanLogic;

        private List<int> numbers;
        private int total = 0;


        public RomanConverter()
        {
            romanLogic = new Dictionary<string, int>()
            {
                {"I",1 },{"V",5 },{"X",10 },{"L",50 }, {"C",100 },{"D",500 }, {"M",1000}
            };

        }


        public int GetArabicNumber(string numberInput)
        {
            numbers = new List<int>();
            foreach (char c in numberInput)
            {
                try
                {
                    int currNumber = ConvertNumber(Char.ToString(c));
                    numbers.Add(currNumber);
                    ConversionLogic();
                }
                catch (Exception)
                {
                    return -1;
                }
            }

            return total;
        }

        private int ConvertNumber(string romanNumber)
        {

            return romanLogic.First(n => n.Key.Equals(romanNumber)).Value;

        }

        private void ConversionLogic()
        {
            int currNumber = numbers.Last();
            int prevNumber = 0;

            // Logiikkatarkistus
            if (numbers.Count > 1)
            {
                prevNumber = numbers[numbers.Count - 2];

                // Vain parit IX, IV,XC ja CM mahdollisia
                if (prevNumber < currNumber)
                {
                    List<(int, int)> possiblePairs = new List<(int, int)>
                        {
                            (1,10),(1,5),(10,50),(10,100),(100,500),(100,1000)
                        };

                    if (!(possiblePairs.Contains((prevNumber, currNumber)))) throw new Exception();
                }


                if (numbers.Count >= 3)
                {
                    int prePrev = numbers[numbers.Count - 3];
                    // Esim IIX ei mahdollinen
                    if ((prevNumber < currNumber) && (prePrev < currNumber)) throw new Exception();

                  

                    // Sama luku ei voi olla 4x putkeen
                    int successiveHits = 0;
                    int prevNum = 0;
                    foreach(int n in numbers)
                    {
                        if(n == prevNum)
                        {
                            successiveHits++;
                        }
                        else
                        {
                            successiveHits = 0;
                        }
                        prevNum = n;
                        if (successiveHits > 2) throw new Exception();
                    }
                }
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
    }
}
