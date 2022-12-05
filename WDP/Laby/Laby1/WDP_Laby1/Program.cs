using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEI
{
    internal class WDP_Laby1
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
            while (value % 3 == 0) value = value / 3;
            if (value != 1) return false;
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
            // Console.WriteLine(czypotega3());
            Console.WriteLine(Kalkulator());
        }
    }
}
