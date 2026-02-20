namespace ConsoleApp
{
    internal class Program
    {

        abstract class Pytanie
        {
            protected string tresc;
            protected string plik;
            protected bool odpowiedz;
            public Pytanie(string tresc, string plik)
            {
                this.tresc = tresc;
                this.plik = plik;
                this.odpowiedz = false;
            }
            public abstract bool czyOdpowiedz(char odp);
        }
        class PytanieZamkniete : Pytanie
        {
            private string pytA;
            private string pytB;
            private string pytC;
            private char poprawnaOdp;
            public PytanieZamkniete(string tresc, string plik, string trescA, string trescB, string trescC, char poprawna) : base(tresc, plik)
            {
                this.pytA = trescA;
                this.pytB = trescB;
                this.pytC = trescC;
                this.poprawnaOdp = poprawna;
            }
            public override bool czyOdpowiedz(char odp)
            {
                return this.poprawnaOdp == odp;
            }
        }

        static void Main(string[] args)
        {
            PytanieZamkniete a = new PytanieZamkniete("test", "test", "testA", "testB", "testC", 'a');
            Console.WriteLine(a.czyOdpowiedz('a').ToString());
        }
    }
}
