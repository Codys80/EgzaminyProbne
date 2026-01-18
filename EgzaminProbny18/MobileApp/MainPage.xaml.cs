namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        int nrPrania = 0;
        bool stanOdkurzacza = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnConfirmPralka(object sender, EventArgs e)
        {
            nrPrania = Convert.ToInt32(entNrPrania.Text);
            if(nrPrania <= 12 && nrPrania != 0)
            lblNrPrania.Text = "Numer prania: " + nrPrania;
        }
        private void btnTurnOnVaccume(object sender, EventArgs e)
        {
            stanOdkurzacza = !stanOdkurzacza;
            lblVaccumeState.Text = "Odkurzacz wyłączony";
            if (stanOdkurzacza)
            lblVaccumeState.Text = "Odkurzacz włączony";
        }
    }

}
