namespace EgzaminProbny14ConsoleApp
{
    internal class Program
    {
        class Film
        {
            protected string tytul;
            protected int liczbaWypozyczen;
            public string getTytul()
            {
                return this.tytul;
            }
            public int getLiczbaWypozyczen()
            {
                return this.liczbaWypozyczen;
            }
            public void setTytul(string tytul)
            {
                this.tytul = tytul;
            }
            public void setLiczbaWypozyczen(int liczbaWypozyczen)
            {
                this.liczbaWypozyczen = liczbaWypozyczen;
            }
            public void inkrement()
            {
                Console.WriteLine("Wartość przed inkrementacją: " + liczbaWypozyczen);
                this.liczbaWypozyczen += 1;
                Console.WriteLine("Wartość po inkrementacją: " + liczbaWypozyczen);
            }
            public Film()
            {
                this.tytul = "";
                this.liczbaWypozyczen = 0;
            }
        }
        static void Main(string[] args)
        {
            Film f = new Film();
            f.setTytul("Title");
            Console.WriteLine( f.getTytul() );
            f.inkrement();
        }
    }
}
