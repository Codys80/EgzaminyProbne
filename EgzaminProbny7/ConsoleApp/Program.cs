namespace EgzaminProbny7ConsoleApp
{
    internal class Program
    {
        class Egzamin
        {
            public int NWD(int a, int b)
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                return a;
            }
        }
        static void Main(string[] args)
        {
            Egzamin E = new Egzamin();
            Console.WriteLine("NWD liczb 16 i 144 to: " + E.NWD(31, 764) );
        }
    }
}
