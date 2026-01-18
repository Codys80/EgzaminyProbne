namespace EgzaminProbny5ConsoleApp
{
    internal class Program
    { 
        class Egzamin
        {
            private int[] tablica = new int[10]; 
            public int szukajMax()
            {
                int tmp = this.tablica[0];
                int iterator = 0;
                int indeksNajwiększej = 0;
                while(iterator < this.tablica.Length)
                {
                    if (this.tablica[indeksNajwiększej] < this.tablica[iterator])
                    {
                        tmp = this.tablica[iterator];
                        indeksNajwiększej = iterator;
                        iterator++;
                    }
                    else
                    {
                        iterator++;
                    }
                }
                return tmp;
            }
            public void sortuj()
            {
                int tmp;
                int indeksMin = 0;
                for (int j = 0; j < tablica.Length; j++)
                {
                    for (int i = j; i < tablica.Length; i++)
                    {
                        if (tablica[indeksMin] > tablica[i])
                        {
                            indeksMin = i;
                        }
                    }
                    tmp = tablica[j];
                    tablica[j] = tablica[indeksMin];
                    tablica[indeksMin] = tmp;
                }
            }
            public void wypisz()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Nr: " + i + " wartość: " + this.tablica[i]);
                }
            }
            public Egzamin()
            {
                Random losowe = new Random();
                for (int i = 0; i < 10; i++)
                {
                    this.tablica[i] = losowe.Next() % 100;
                }
                wypisz();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Egzamin E = new Egzamin();
            Console.WriteLine("Wartość maksymalna: "+E.szukajMax());
            E.sortuj();
            Console.WriteLine("Wypis");
            E.wypisz();
        }
    }
}
