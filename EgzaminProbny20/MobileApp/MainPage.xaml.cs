namespace MobileApp
{
    public partial class MainPage : ContentPage
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
            public string getPlik()
            {
                return this.plik;
            }
            public string getTresc()
            {
                return tresc;
            }
        }

        int punkty, indeks;
        char odpUzytkownika;
        List<PytanieZamkniete> listaPytan = new List<PytanieZamkniete>();
        public MainPage()
        {
            InitializeComponent();
            listaPytan.Add(
                new PytanieZamkniete(
                    "Które to schronisko?",
                    "zad1.jpg",
                    "Na Rysiance",
                    "Na Wielkiej Raczy.",
                    "Na Wielkiej Rycerzowej.",
                    'B'
                    )
                );
            listaPytan.Add(
                new PytanieZamkniete(
                    "Które to schronisko?",
                    "zad2.jpg",
                    "Na Rysiance",
                    "Na Wielkiej Raczy.",
                    "Na Wielkiej Rycerzowej.",
                    'C'
                    )
                );
            listaPytan.Add(
                new PytanieZamkniete(
                    "Które to schronisko?",
                    "zad3.jpg",
                    "Na Rysiance",
                    "Na Wielkiej Raczy.",
                    "Na Wielkiej Rycerzowej.",
                    'A'
                    )
                );
        }
        public void Display()
        {
            imgDisplay.Source = listaPytan[indeks].getPlik();
            lblDisplay.Text = listaPytan[indeks].getTresc();
        }
        private void OnNextClicked(object sender, EventArgs e)
        {
            if (listaPytan[indeks].czyOdpowiedz(odpUzytkownika)) punkty += 1;
            else { indeks = 0; Display(); return; }

            if (indeks == listaPytan.Count - 1)
            {
                indeks = 0;
            }
            else indeks += 1;
            Display();
        }
        private void OnRadioChange(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            odpUzytkownika = Convert.ToChar(radio.Value);
        }
    }

}
