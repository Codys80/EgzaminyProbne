namespace EgzaminProbny6ConsoleApp
{
    internal class Program
    {
        class Egzamin
        {
            public void wyszukaj(int element)
            {
                for(int i = 0; i<this.tablica.Length; i++)
                {
                    if (this.tablica[i] == element)
                    {
                        Console.WriteLine("Odnaleziono " + element + " | Nr indeksu: " + i);
                        break;
                    }
                    else if(i == this.tablica[49])
                    {
                        Console.WriteLine("Nie odnaleziono elementu");
                        break;
                    }
                }
            }
            private Random losowe = new Random();
            private int[] tablica = new int[50];
            public Egzamin()
            {
                for(int i = 0; i < this.tablica.Length; i++)
                {
                    this.tablica[i] = losowe.Next() % 50;
                    Console.WriteLine("Nr indeksu: "+ i +" | wartość: "+ this.tablica[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Egzamin E = new Egzamin();
            E.wyszukaj(20);
        }
    }
}
