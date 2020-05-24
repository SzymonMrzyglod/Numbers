using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Sprawdzenie
    {
        static void Main(string[] args)
        {

            for (int podanaliczba = 1; podanaliczba <= 100; podanaliczba++)
            {
                LiczbaPierwsza liczba = new LiczbaPierwsza();
                liczba.SprawdzLiczbe(podanaliczba);
            }

            Console.ReadKey();
        }
    }
}
