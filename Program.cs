using System;
using System.Threading;

namespace RomanNumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("RomanConverter 1.0 by Jari Poutanen");
            Thread.Sleep(1000);

            bool run = true;

            while(run)
            {

                RomanNumberService srv = new RomanNumberService();
                run = srv.RunService(); 
            }



            Thread.Sleep(1000);
            Console.WriteLine("Mukavaa päivänjatkoa!");



        }
    }
}
