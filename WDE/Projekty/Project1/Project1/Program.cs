namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ZADANIE 8.2.1 AND //ZADANIE 8.2.2
            Console.WriteLine("Input number of cykles: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tabs = new int[n];
            int max = 0;
            int min = 1000000000;
            for (int y=0;y<n;y++)
            {
                Console.WriteLine($"Input {y+1} cykles: ");
                tabs[y] = Convert.ToInt32(Console.ReadLine());
                if (tabs[y] > max) max = tabs[y];
                else min = tabs[y];
            }
            Console.WriteLine($"Max = {max}, Min = {min}");
            
            //ZADANIE 8.2.3

            //ZADANIE 8.2.4
            //ZADANIE 8.2.5
            //ZADANIE 8.2.6
            //ZADANIE 8.2.7
            //ZADANIE 8.2.8

            //ZADANIE 8.3.1
            //ZADANIE 8.3.2
            //ZADANIE 8.3.3
            //ZADANIE 8.3.4

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