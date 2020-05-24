using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class LiczbaPierwsza
    {
        int iloscDzielnikow = 0;
        public void SprawdzLiczbe(int podanaLiczba)
        {
            if (podanaLiczba <= 0)
            {
                throw new System.FormatException();      //Wyłapanie własnego wyjątku.
            }
            else
            {
                for (int i = 2; i < podanaLiczba; i++)      //Pominięte dwa dzielniki 1 i "podanaLIczba".
                {
                    if (podanaLiczba % i == 0)
                    {
                        iloscDzielnikow++;
                    }
                }
                if (iloscDzielnikow > 0 || podanaLiczba == 1)
                {
                    //Console.WriteLine($"\n  Podana liczba {podanaLiczba} nie jest liczbą pierwszą.\n");
                }
                else
                {
                    Console.Write(/*$"\n  Podana liczba {*/podanaLiczba + ", "/*} jest liczbą pierwszą.\n"*/);
                }
            }
        }
        public void RozlozLiczbe(int podanaLiczba)
        {
            if (podanaLiczba <= 0)
            {
                throw new System.FormatException();
            }
            else
            {
                Console.WriteLine("  Podana liczba dzieli się przez:");
                Console.Write($"\n      Liczba|Dzielnik");
                int nowaLiczba = podanaLiczba;
                int j = 2;      //Rozkład liczby zaczynamy od dzielenia przez 2.
                while (nowaLiczba != 1)
                {
                    if (nowaLiczba % j == 0)
                    {
                        Console.Write($"\n  {nowaLiczba,10}|{j}\t");
                        nowaLiczba = nowaLiczba / j;
                    }
                    else
                    {
                        j++;
                    }
                }
                Console.Write($"\n  {1,10}|");
            }
        }
        public int[] WyznaczDzielnikiLiczby(int liczba)
        {
            Console.WriteLine($"\n\n  Dzielniki liczby {liczba}:");
            int wielkosc = 0;      //Nowa zmienna "wielkość" potrzeba do stworzenia tablicy.
            int wartoscBezwzgledna = Math.Abs(liczba);      //Konieczne przy liczbach ujemnych.
            for (int i = 1; i <= wartoscBezwzgledna; i++)
            {
                if (wartoscBezwzgledna % i == 0)
                {
                    wielkosc++;
                }
            }
            int[] tablica = new int[wielkosc];
            int indeks = 0;

            for (int i = 1; i <= wartoscBezwzgledna; i++)
            {
                if (wartoscBezwzgledna % i == 0)
                {
                    tablica[indeks] = i;
                    Console.Write("  " + tablica[indeks]);
                    indeks++;
                }
            }
            return tablica;
        }
        public void WyznaczNWD(int[] pierwszaTablica, int[] drugaTablica)
        {
            int NWD = pierwszaTablica[0];      //Przyjęto, że NWD to liczba z zerowego indeksu.
            for (int i = 0; i < pierwszaTablica.Length; i++)
            {
                for (int j = 0; j < drugaTablica.Length; j++)
                {
                    if (pierwszaTablica[i] == drugaTablica[j])
                    {
                        NWD = pierwszaTablica[i];      //Przypisanie nowej wartości NWD w przypadku znalezienia większego dzielnikia.
                    }
                }
            }
            Console.WriteLine("\n\n  NWD = " + NWD);

        }
    }
}

