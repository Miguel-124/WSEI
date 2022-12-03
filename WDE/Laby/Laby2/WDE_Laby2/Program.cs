namespace WSEI
{
    internal class WDE_Laby2
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
                    int tab2 = tab[row+1];
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