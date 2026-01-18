namespace EgzaminProbny15ConsoleApp
{
    internal class Program
    {
        class Egzamin
        {
            private int[] tab;
            private int liczbaElementów;
            public void wyswietl()
            {
                for(int i = 0; i < liczbaElementów; i++)
                {
                    Console.WriteLine(i+ ": " + tab[i]);
                }
            }
            public int szukaj(int szukana)
            {
                for (int i = 0; i < liczbaElementów; i++)
                {
                    if (tab[i] == szukana)
                    {
                        return i;
                    }
                }
                return -1;
            }
            public int nieparzyste()
            {
                int count = 0;
                for (int i = 0; i < liczbaElementów; i++)
                {
                    if (tab[i] % 2 == 1)
                    {
                        count++;
                        Console.WriteLine(tab[i]);
                    }
                }
                return count;
            }
            public double srednia()
            {
                double srednia = 0;
                for (int i = 0; i < liczbaElementów; i++)
                {
                    srednia += tab[i];
                }
                return srednia /= liczbaElementów;
            }
            public Egzamin(int rozmiar)
            {
                this.liczbaElementów = rozmiar;
                tab  = new int[liczbaElementów];
                Random random = new Random();
                for(int i = 0; i < this.tab.Length; i++)
                {
                    tab[i] = random.Next() % 1000 + 1;
                }
            }
        }
        static void Main(string[] args)
        {
            Egzamin E = new Egzamin(21);
            E.wyswietl();
            if(E.szukaj(10) != -1) Console.WriteLine("Szukana 10: index: " + E.szukaj(10));
            Console.WriteLine("Liczby nieparzyste: ");
            E.nieparzyste();
            Console.WriteLine("Srednia: " + E.srednia());

        }
    }
}
