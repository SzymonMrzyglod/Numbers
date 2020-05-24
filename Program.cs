//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Projekt
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        Menu:
//            Console.Title = "Menu";
//            Console.WriteLine("\n   >>>MENU PROGRAMU<<<\n\n" +
//                    "   1 - Liczba Pierwsza\n" +
//                    "   2 - Rozłóż Liczbę\n" +
//                    "   3 - Dzielniki Liczby\n" +
//                    "   4 - Największy Wspólny Dzielnik\n" +
//                    " ESC - Zakończ\n\n" +
//                    "Wciśnij odpowiedni klawisz...");

//            ConsoleKeyInfo znak = Console.ReadKey();

//            try      //Sprawdzanie czy wprowadzono prawidłowy znak.
//            {
//                switch (znak.Key)
//                {
//                    case ConsoleKey.D1:
//                    case ConsoleKey.NumPad1:
//                        {
//                            Console.Clear();
//                            Console.Title = "Liczby Pierwsze";

//                            Console.WriteLine("\n >>SPRAWDŹ CZY LICZBA NALEŻY DO LICZB PIERWSZYCH<<\n\n");
//                            Console.Write("  Podaj liczbę naturalną dodatnią: ");
//                            int podanaLiczba = int.Parse(Console.ReadLine());

//                            LiczbaPierwsza pierwszaLiczba = new LiczbaPierwsza();      //Stworzenie nowego obiektu klasy "LiczbaPierwsza".
//                            pierwszaLiczba.SprawdzLiczbe(podanaLiczba);

//                            goto WrocLubZakoncz;      //Przejscie do etykiety "WrocLubZakoncz"
//                        }

//                    case ConsoleKey.D2:
//                    case ConsoleKey.NumPad2:
//                        {
//                            Console.Clear();
//                            Console.Title = "Rozłożenie Liczby";

//                            Console.WriteLine("\n >>ROZŁÓŻ LICZBE NA CZYNNIKI PIERWSZE<<\n\n");
//                            Console.Write("  Podaj liczbę naturalną dodatnią: ");
//                            int podanaLiczba = int.Parse(Console.ReadLine());

//                            LiczbaPierwsza pierwszaLiczba = new LiczbaPierwsza();
//                            pierwszaLiczba.RozlozLiczbe(podanaLiczba);

//                            goto WrocLubZakoncz;
//                        }

//                    case ConsoleKey.D3:
//                    case ConsoleKey.NumPad3:
//                        {
//                            Console.Clear();
//                            Console.Title = "Dzielniki Liczby";

//                            Console.WriteLine("\n >>WYZNACZ DZIELNIKI LICZBY<<\n\n");
//                            Console.Write("  Podaj liczbę całkowitą: ");
//                            int podanaLiczba = int.Parse(Console.ReadLine());

//                            LiczbaPierwsza pierwszaLiczba = new LiczbaPierwsza();
//                            pierwszaLiczba.WyznaczDzielnikiLiczby(podanaLiczba);

//                            goto WrocLubZakoncz;
//                        }

//                    case ConsoleKey.D4:
//                    case ConsoleKey.NumPad4:
//                        {
//                            Console.Clear();
//                            Console.Title = "NWD";

//                            Console.WriteLine("\n >>WYZNACZ NAJWIĘKSZY WSPÓLNY DZIELNIK (NWD)<<\n\n");
//                            Console.Write("  Podaj pierwszą liczbę całkowitą: ");
//                            int podanaLiczba = int.Parse(Console.ReadLine());

//                            LiczbaPierwsza pierwszaLiczba = new LiczbaPierwsza();

//                            Console.Write("  Podaj drugą liczbę całkowitą: ");
//                            int drugaPodanaLiczba = int.Parse(Console.ReadLine());

//                            LiczbaPierwsza drugaLiczba = new LiczbaPierwsza();

//                            //Jako argumenty metody wyznaczNWD podano tablicę zwróconą przez metodę "wyznaczDzielnikiLiczby".
//                            pierwszaLiczba.WyznaczNWD(pierwszaLiczba.WyznaczDzielnikiLiczby(podanaLiczba),
//                                                   drugaLiczba.WyznaczDzielnikiLiczby(drugaPodanaLiczba));

//                            goto WrocLubZakoncz;
//                        }

//                    case ConsoleKey.Escape:
//                        {
//                            Environment.Exit(0);      //Zamknięcie aplikacji

//                            break;
//                        }
//                }
//            }
//            catch (System.Exception e)      //Wystąpienie wyjątku.
//            {
//                Console.WriteLine("\n\n\n >>PODANO NIEPRAWIDŁOWY ZNAK!<<");
//                Console.WriteLine("\n Komunikat systemowy: " + e.ToString());

//                goto WrocLubZakoncz;
//            }

//            //Nie wybranie odpowiedniej pozycji w menu spowoduje ominięcie instrukcji "Switch...Case"
//            Console.Clear();
//            Console.WriteLine("\n >>WPROWADZONO ZŁY ZNAK!<<");

//        WrocLubZakoncz:
//            Console.WriteLine("\n\n\n Wciśnij ENTER aby wrócić do menu programu lub ESC aby zakończyć działanie... ");

//            ConsoleKeyInfo wrocLubZakoncz = Console.ReadKey();
//            if (wrocLubZakoncz.Key == ConsoleKey.Enter)
//            {
//                Console.Clear();
//                goto Menu;
//            }
//            else if (wrocLubZakoncz.Key == ConsoleKey.Escape)
//            {
//                Environment.Exit(0);
//            }
//            else
//            {
//                goto WrocLubZakoncz;
//            }
//        }

//    }
//}
