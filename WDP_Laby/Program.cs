
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEI
{
    internal class Program
    {


        static float Kalkulator()
        {
            Console.WriteLine("Program zlicza podstawowe dzialania na dwoch liczbach");
            Console.WriteLine("Podaj pierwsza dowolna liczba:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj druga dowolna liczbe:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj działanie:");
            Console.WriteLine("1 = suma");
            Console.WriteLine("2 = odejmowanie");
            Console.WriteLine("3 = dzielenie");
            Console.WriteLine("4 = mnożenie");
            Console.WriteLine("5 = Koniec pracy");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wynik");

            switch (c)
            {
                case 1:
                    float suma = (a + b);
                    return suma;
                case 2:
                    float odejmowanie = (a - b);
                    return odejmowanie;
                case 3:
                    float dzielenie = (a / b);
                    return dzielenie;
                case 4:
                    float mnozenie = (a * b);
                    return mnozenie;
                case 5:
                    Console.WriteLine("Koniec pracy");
                    break;
                default:
                    Console.WriteLine("Źle");
                    break;
            }
            return 0;
        }

        static bool czypotega3()
        {
            Console.WriteLine("Enter your value:");
            int value = Convert.ToInt32(Console.ReadLine());
            while (value % 3 == 0) value = value/3;
            if (value!=1) return false;
            else return true;
        }

        static void Fibonaci()
        {
            Console.WriteLine("Ciąg Fibonaciego");
            int a = 1;
            int b = 1;
            for (int i = 0; i < 10; i++)
            {
                int c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(czypotega3());
            Console.WriteLine(Kalkulator());
        }
    }
}
namespace WSEI
{
    internal class Zaj2

    {
        static void printTable(int[] tablica)
        {
            string tab = "[";
            for (int i = 0; i < tablica.Length; i++)
            {
                tab += tablica[i];
                if (i < tablica.Length - 1)
                {
                    tab += ",";
                }
            }
            tab += "]";
            Console.WriteLine(tab);
        }


        static void Main(string[] args)
        {
            //int[] table = { 3, 6, -8, 9, 10, 12 };
            //int max = table[0];

            //foreach (int row in table)
            //{
            //    if(row>max)
            //    {
            //        max = row;
            //    }
            //}
            //Console.WriteLine("Max = "+max);


            //int number = 17;
            //int dzielnik = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0) dzielnik++;
            //}
            //if (dzielnik == 2) Console.WriteLine("Jest pierwsza");
            //else Console.WriteLine("Nie jest pierwsza");


            int[] tab = { 3, 1, 2, 8, 3, 7 };
            printTable(tab);
            bool zmiana = false;
            do
            {
                for (int row = 0; row < tab.Length; row++)
                {
                    int tab1 = tab[row];
                    int tab2 = tab[row + 1];
                    if (tab1 > tab2)
                    {
                        int wait;
                        wait = tab[row + 1];
                        tab[row + 1] = tab[row];
                        tab[row] = wait;
                        zmiana = true;
                    }
                }
            } while (zmiana);
        }
    }
}