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

        //ZADANIE 8.4.1
        void Zad841()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 0; y < n; y++)
            {
                if (tab[y] % 2 == 0) Console.WriteLine(tab[y]);
            }
        }

        //ZADANIE 8.4.2
        void Zad842()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 0; y < n; y++)
            {
                if (tab[y] % 2 != 0) Console.WriteLine(tab[y]);
            }
        }

        //ZADANIE 8.4.3
        void Zad843()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 0; y < n; y++)
            {
                if (tab[y] % 3 == 0) Console.WriteLine(tab[y]);
            }
        }


        //ZADANIE 8.4.4
        void Zad844()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 0; y < n; y++)
            {
                if (tab[y] >= 4 && tab[y] < 15) Console.WriteLine(tab[y]);
            }
        }


        //ZADANIE 8.4.5
        void Zad845()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 0; y < n; y++)
            {
                if (tab[y] % 2 == 0)
                {
                    int tempTab = tab[y];
                    while (tempTab / 10 != 0)
                    {
                        tempTab /= 10;
                        if (tempTab % 2 != 0) goto End;
                    }
                    Console.WriteLine(tab[y]);
                End:;
                }
            }
        }


        //ZADANIE 8.4.6
        void Zad846()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 0; y < n; y++)
            {
                if (tab[y] % 10 == 0 || tab[y] / 1 == 1)
                {
                    int tempTab = tab[y];
                    while (tempTab % 10 == 0)
                    {
                        tempTab /= 10;
                        if (tempTab % 10 != 0 && tempTab / 1 != 1) goto End;
                    }
                    Console.WriteLine(tab[y]);
                End:;
                }
            }
        }


        //ZADANIE 8.4.7
        void Zad847()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 0; y < n; y++)
            {
                if (tab[y] % 2 == 0) Console.WriteLine(tab[y] + 100);
                else Console.WriteLine(tab[y]);
            }
        }


        //ZADANIE 8.4.8
        void Zad848()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 0; y < n; y++)
            {
                if (tab[y] < 0) Console.WriteLine(0);
                else Console.WriteLine(tab[y]);
            }
        }


        //ZADANIE 8.5.1
        void Zad851()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 0; y < n; y++)
            {
                if (y % 2 == 0) Console.WriteLine(tab[y]);
            }
        }


        //ZADANIE 8.5.2
        void Zad852()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 1; y < n; y++)
            {
                if (Math.Sqrt(Convert.ToDouble(y)) % 1 == 0) Console.WriteLine(tab[y]);
            }
        }


        //ZADANIE 8.6.1
        void Zad861()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n + 1];
            for (int y = 1; y <= n; y++)
            {
                tab[y] = y;
            }
            Console.WriteLine("Result:");
            for (int y = 1; y <= n; y++)
            {
                int ile = 0;
                for (int x = 1; x <= y; x++)
                {
                    if (tab[y] % x == 0) ile++;
                    if (ile > 2) goto End;
                }
                Console.Write($"{tab[y]}, ");
            End:;
            }
        }


        //ZADANIE 8.6.2
        void Zad862()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            tab[0] = 1; tab[1] = 1;
            for (int y = 2; y < n; y++)
            {
                tab[y] = tab[y - 1] + tab[y - 2];
            }
            Console.WriteLine("Result:");
            for (int y = 0; y <= n; y++)
            {
                Console.Write($"{tab[y]}, ");
            }
        }


        //ZADANIE 8.6.3
        void Zad863()
        {

        }


        //ZADANIE 8.6.4
        void Zad864()
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tabA = new int[n];
            int[] tabB = new int[n];
            int[] tabC = new int[n];
            int[] tabD = new int[n];
            int[] tabE = new int[n];

            Console.WriteLine("ResultA:");
            for (int y = 0; y < n; y++)
            {
                tabA[y] = y;
                Console.Write($"{tabA[y]}, ");
            }

            Console.WriteLine("\nResultB:");
            for (int y = 0; y < n; y++)
            {
                tabB[y] = y + 7;
                Console.Write($"{tabB[y]}, ");
            }

            Console.WriteLine("\nResultC:");
            for (int y = 0; y < n; y++)
            {
                if (y == 0)
                {
                    tabC[y] = 0;
                    continue;
                }
                tabC[y] = tabC[y - 1] + 4;
                Console.Write($"{tabC[y]}, ");
            }

            Console.WriteLine("\nResultD:");
            for (int y = 0; y < n; y++)
            {
                if (y == 0)
                {
                    tabD[y] = 1;
                    goto Next;
                }
                if (y == 1)
                {
                    tabD[y] = 2;
                    goto Next;
                }
                //Kwadrat poprzedniej liczby
                //tabD[y] = Convert.ToInt32(Math.Pow(Convert.ToDouble(tabD[y - 1]),2));
                tabD[y] = tabD[y - 1] * 2;
                Next:;
                Console.Write($"{tabD[y]}, ");
            }

            Console.WriteLine("\nResultE:");
            for (int y = 0; y < n; y++)
            {
                tabE[y] = y + 2;
                Console.Write($"{tabE[y]}, ");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            int[] tabMin = new int[n];
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine($"Input {y + 1} cykles: ");
                tab[y] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result:");
            for (int y = 1; y <= n; y++)
            {
                int temp = tab[y-1];
                for(int x=n;x>0;--x)
                {
                    if (temp > tab[x] && temp != tabMin[y - 1])
                    {
                        temp = tab[x];
                        tabMin[y - 1] = temp;
                    }
                    else
                    {
                        for(int z = 0;z<tabMin.Length;z++)
                        {
                            if (temp == tabMin[z])
                            {
                                // TODO:  dOKOŃCZYĆ ustawianie po minimum
                            }
                        }
                    }
                }
            }
            foreach (var item in tabMin)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}