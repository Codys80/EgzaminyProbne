namespace EgzaminProbny9ConsoleApp
{
    internal class Program
    {
        class Egzamin
        {
            private int[] PESEL = new int[11] { 5, 5, 0, 3, 0, 1, 0, 1 ,1 ,9 ,3 };
            public char sprawdźPłeć()
            {
                if(PESEL[PESEL.Length-1] % 2 == 0) return 'K';
                return 'M';
            }
            public bool sprawdźCyfręKontrolną()
            {
                int s = (PESEL[0] * 1)+(PESEL[1] * 3) +(PESEL[2] * 7) +(PESEL[3] * 9) +(PESEL[4] * 1) +(PESEL[5] * 3) +(PESEL[6] * 7) +(PESEL[7] * 9) +(PESEL[8] * 1)+(PESEL[9] * 3);
                int m = s % 10;
                int r = 0;
                if (m != 0) r = 10 - m;
                if (r == PESEL[10]) return true;
                return false;
            }
        }
        static void Main(string[] args)
        {
            Egzamin E = new Egzamin();
            Console.WriteLine(E.sprawdźCyfręKontrolną());
            Console.WriteLine(E.sprawdźPłeć());
        }
    }
}
