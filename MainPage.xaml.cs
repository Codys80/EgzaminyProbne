using Windows.Management.Deployment;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EgzaminProbny8MobileApp
{
    public partial class MainPage : ContentPage
    {
        private int radioId;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConfirmClicked(object sender, EventArgs e)
        {
            string postalCode = "";
            if (entPostalCode.Text != null) postalCode = entPostalCode.Text;
            string streetNumber = entStreetNumber.Text;
            string city = entCity.Text;
            string message = "Dane przesyłki zostały wprowadzone";
            if (postalCode.Length == 5)
                for (int i = 0; i < postalCode.Length; i++)
                {
                    if (!Char.IsDigit(postalCode[i]))
                    {
                        DisplayAlert("Błąd", "Kod pocztowy powinien się składać z samych cyfr", "OK");
                        break;
                    }
                }
            else message = "Nieprawidłowa liczba cyfr w kodzie pocztowym";
            DisplayAlert("Komunikat", message, "OK");
        }
        private void OnRadioCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            radioId = Convert.ToInt32(radioButton.Value);
        }
        private void OnCheckClicked(object sender, EventArgs e)
        {
            switch (radioId)
            {
                case 1:
                    imgPackageIcon.Source = "pocztowka.png";
                    lblPrice.Text = "Cena: 1zł";
                    break;
                case 2:
                    imgPackageIcon.Source = "list.png";
                    lblPrice.Text = "Cena: 1.5zł";
                    break;
                case 3:
                    imgPackageIcon.Source = "paczka.png";
                    lblPrice.Text = "Cena: 10zł";
                    break;
            }
            
        }
    }

}
