namespace EgzaminProbny11ConsoleApp
{
    internal class Program
    {
        class RozmiarSkrytki : Program
        {
            public int getRozmiarSkrytki()
            {
                return this.rozmiar;
            }
            protected int rozmiar;
            public RozmiarSkrytki()
            {
                this.rozmiar = 0;
            }
            public RozmiarSkrytki(string rozmiarWejściowy)
            {
                switch (rozmiarWejściowy)
                {
                    case "Maly":
                        this.rozmiar = 10;
                        break;
                    case "Sredni":
                        this.rozmiar = 20;
                        break;
                    case "Duzy":
                        this.rozmiar = 30;
                        break;
                }
            }
        }
        class Skrytka : RozmiarSkrytki
        {
            private static int liczbaInstancji;
            private string zawartosc;
            private string kod;
            private RozmiarSkrytki rozmiarSkrytki;
            public string getKod()
            {
                return this.kod.ToString();
            }
            public int getRozmiarSkrytki()
            {
                return this.rozmiarSkrytki.getRozmiarSkrytki();
            }
            public int getLiczbaInstancji()
            {
                return Skrytka.liczbaInstancji;
            }
            public bool czyPusta()
            {
                if(this.zawartosc == null || this.zawartosc == "" || this.zawartosc == " ")
                {
                    return false;
                }
                return true;
            }
            public void generujKod()
            {
                Random rand = new Random();
                char[] kodBudowa = new char[5];
                for (int i = 0; i < kodBudowa.Length; i++)
                {
                    kodBudowa[i] = Convert.ToChar(  (rand.Next() % 10).ToString() ) ;
                }
                this.kod = new string(kodBudowa);
            }
            public bool umiescPaczke(string paczka)
            {

                if (czyPusta())
                {
                    int paczkaRozmiar = 0;
                    switch (paczka)
                    {
                        case "Maly":
                            paczkaRozmiar = 10;
                            break;
                        case "Sredni":
                            paczkaRozmiar = 20;
                            break;
                        case "Duzy":
                            paczkaRozmiar = 30;
                            break;
                    }
                    if (paczkaRozmiar > this.rozmiarSkrytki.getRozmiarSkrytki()) return false;

                    this.zawartosc = paczka;
                    this.generujKod();
                    Console.WriteLine("Kod paczki: " + this.kod);
                    return true;
                }
                return false;
            }
            public bool otworzSkrytke(string kodWejściowy)
            {
                if(kodWejściowy == this.kod)
                {
                    Console.WriteLine("Otwarto\nRozmiar paczki: " + this.rozmiar);
                    zawartosc = "";
                    return true;
                }
                return false;
            }
            public Skrytka(string rozmiarWejściowy)
            {
                this.rozmiarSkrytki = new RozmiarSkrytki(rozmiarWejściowy);
                liczbaInstancji = liczbaInstancji + 1;
                generujKod();
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
