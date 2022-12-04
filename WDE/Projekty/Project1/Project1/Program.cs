namespace Project1
{
    internal class Program
    {
        static void Zad82()
        {
            //ZADANIE 8.2.1
            //ZADANIE 8.2.2
            //ZADANIE 8.2.3
            //ZADANIE 8.2.4 
            //ZADANIE 8.2.5 
            //ZADANIE 8.2.6 
            //ZADANIE 8.2.7 
            //ZADANIE 8.2.8 
            //In this homework is bug that min2 or max2 can not occure

            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tabs = new int[n];
            int max = 0;
            int min = 0;
            int max2 = 0;
            int min2 = 0;
            int minRepeat = -1;
            int maxRepeat = -1;
            int min2Repeat = -1;
            int max2Repeat = -1;
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tabs[y] = Convert.ToInt32(Console.ReadLine());
                if (y == 0)
                {
                    max = tabs[y];
                    min = tabs[y];
                }

                if (tabs[y] > max)
                {
                    max2 = max;
                    max = tabs[y];
                }
                else if (tabs[y] < min)
                {
                    min2 = min;
                    min = tabs[y];
                }

                if (tabs[y] == max) maxRepeat++;
                else if (tabs[y] == min) minRepeat++;
                if (tabs[y] == max2) max2Repeat++;
                else if (tabs[y] == min2) min2Repeat++;
            }
            Console.WriteLine($"Max = {max}, Min = {min}, Max2 = {max2}, Min2 = {min2}, MaxRepeat = {maxRepeat}, MinRepeat = {minRepeat},");

        }

        void Zad83()
        {
            //ZADANIE 8.3.1
            //ZADANIE 8.3.2
            //ZADANIE 8.3.3
            //ZADANIE 8.3.4
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            double[] tab2 = new double[n];
            double[] tab3 = new double[n];
            int[] tabPlusOne = new int[n];
            int[] tabMultiplyByTwo = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
                tab2[y] = Math.Pow(tab[y], 2);
                tab3[y] = Math.Pow(tab[y], 3);
                tabPlusOne[y] = tab[y] + 1;
                tabMultiplyByTwo[y] = tab[y] * 2;
                Console.WriteLine($"Iteration {y + 1}");
                Console.WriteLine($"Tab = {tab[y]}, Tab2 = {tab2[y]}, Tab3 = {tab3[y]}, TabPlusOne = {tabPlusOne[y]}, tabMultiplyByTwo = {tabMultiplyByTwo[y]}");
            }
        }

        void Zad84()
        {

        }

        void Zad85()
        {

        }

        void Zad86()
        {

        }

        static void Main(string[] args)
        {
            //ZADANIE 8.4.1
            //ZADANIE 8.4.2
            //ZADANIE 8.4.3
            //ZADANIE 8.4.4
            //ZADANIE 8.4.5
            //ZADANIE 8.4.6
            //ZADANIE 8.4.7
            //ZADANIE 8.4.8


            //ZADANIE 8.5.1
            //ZADANIE 8.5.2

            //ZADANIE 8.6.1
            //ZADANIE 8.6.2
            //ZADANIE 8.6.3
            //ZADANIE 8.6.4

        }
    }
}