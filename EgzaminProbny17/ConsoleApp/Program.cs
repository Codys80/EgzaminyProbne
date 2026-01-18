namespace ConsoleApp
{
    internal class Program
    {
        class Egzamin
        {
            public void sortuj(int[] tab)
            {
                for(int i = 0; i <= tab.Length - 2; i++)
                {
                    for(int j = 0; j <= tab.Length - 2; j++)
                    {
                        if (tab[j] > tab[j + 1])
                        {
                            int temp = tab[j + 1];
                            tab[j + 1] = tab[j];
                            tab[j] = temp;
                        }
                    }
                }
                foreach (int i in tab)
                {
                    Console.Write(i + ", ");
                }
            }
        }
        static void Main(string[] args)
        {
            Egzamin E = new Egzamin();
            Random rand = new Random();
            int[] tab = new int[25];
            for(int i = 0; i< tab.Length; i++)
            {
                tab[i] = rand.Next() % 1000;
            }
            E.sortuj(tab);
        }
    }
}
