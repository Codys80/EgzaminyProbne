namespace EgzaminProny8ConsoleApp
{
    internal class Program
    {
        class Egzamin
        {
            private bool[] tablica = new bool[100];
            public void Erastotenes()
            {
                for(int i = 2; i < Math.Sqrt(tablica.Length); i++)
                {
                    if (tablica[i])
                    {
                        for(int j = 2; j < tablica.Length; j = (j + 1 * i))
                        {
                            tablica[j] = false;
                        }
                    }
                }
                wypiszPierwsze();
            }
            public void wypiszPierwsze()
            {
                Console.Write("Liczby pierwsze:");
                for(int i = 0; i<tablica.Length; i++)
                {
                    if (tablica[i]) Console.Write(" "+i);
                }
            }
            public Egzamin()
            {
                for(int i = 0; i<tablica.Length; i++)
                {
                   tablica[i] = true;
                }
                Erastotenes();
            }
        }
        static void Main(string[] args)
        {
            Egzamin E = new Egzamin();
            
        }
    }
}
