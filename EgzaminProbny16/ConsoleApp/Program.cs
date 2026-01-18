using System.Drawing;

namespace ConsoleApp
{
    internal class Program
    {
        class Egzamin
        {
            private int[,] tab ;
            private int[] wystapienia;
            //**********************************************
            //nazwa funkcji: wyswietl
            //opis funkcji: funkcja wyswietla wyniki losowania
            //parametry: brak
            //zwracany brak
            //autor: CodyS80
            //***********************************************
            public void wyswietl()
            {
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    Console.WriteLine("Zestaw:" + (i + 1));
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(tab[i, j] + ", ");
                    }
                    Console.Write('\n');
                }
                for (int i = 0; i < wystapienia.Length; i++)
                {
                    Console.WriteLine("Wystąpienia liczby " + i + ": " + (wystapienia[i]));
                }
            }
            //**********************************************
            //nazwa funkcji: wypelnij
            //opis funkcji: funkcja wypełnia tablice losowaniami
            //parametry: int rozmiar - reprezentuje ilość losowań, rozmiar tablicy
            //zwracany brak
            //autor: CodyS80
            //***********************************************
            public void wypelnij(int rozmiar)
            {
                Random rand = new Random();
                this.tab = new int[rozmiar, 6];
                this.wystapienia = new int[50];
                for (int i = 0; i < rozmiar; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        tab[i, j] = rand.Next() % 49 + 1;
                        wystapienia[tab[i, j]] += 1;
                    }
                }
                wyswietl();
            }
            public Egzamin(int rozmiar)
            {
                wypelnij(rozmiar);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ile wygenerować losowań: ");
            Egzamin E = new Egzamin( Convert.ToInt32(Console.ReadLine() )  );
        }
    }
}
