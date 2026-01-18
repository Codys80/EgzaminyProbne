using Microsoft.Maui.ApplicationModel.Communication;

namespace EgzaminProbnyMobileApp
{
    public partial class MainPage : ContentPage
    {
        private string email;
        private string password;
        public MainPage()
        {
            InitializeComponent();
        }

        private void onConfirmClicked(object sender, EventArgs e)
        {
            bool isLoginValid = true;
            lblLoginMessage.Text = "";

            if(entEmail.Text != null) email = entEmail.Text;
            if(entPassword.Text != null) password = entPassword.Text;

            if (!email.Contains('@'))
            {
                lblLoginMessage.Text = "Nieprawidłowy adres e-mail\n";
                isLoginValid = false;
            }
            if (password != entPasswordRepeat.Text)
            {
                lblLoginMessage.Text += "Hasła się różnią";
                isLoginValid = false;
            }

            if(isLoginValid) lblLoginMessage.Text = "Witaj " + email;
        }
    }

}
