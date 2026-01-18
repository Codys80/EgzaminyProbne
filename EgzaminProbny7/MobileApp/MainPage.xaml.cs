using System.Text;
using System.Xml.Linq;

namespace EgzaminProbny7MobileApp
{
    public partial class MainPage : ContentPage
    {
        private int charLength;
        private bool specials, numbers, chars;
        private string role, name, surname, pool;
        private string password = " ";
        public MainPage()
        {
            InitializeComponent();
        }
        private void onConfirmClicked(object sender, EventArgs e)
        {
            name = entName.Text;
            surname = entSurname.Text;
            role = pckRole.SelectedItem.ToString();
            string message = "Dane pracownika: "+ name + " " + surname + " " + role + " Hasło: " + password;
            DisplayAlert("Dane pracownika", message, "OK");
        }
        private void onGenerateClicked(object sender, EventArgs e)
        {
            pool = "";
            charLength = Convert.ToInt32(entCharLength.Text);
            chars = chkChars.IsChecked;
            numbers = chkNumbers.IsChecked;
            specials = chkSpecials.IsChecked;
            if (chars) pool = "abcdefghijklmnoprstuwxyzABCDEFGHIJKLMNOPRSTUWXYZ";
            if (numbers) pool += "1234567890";
            if (specials) pool += "!@#$%^&*()_+-=";
            Random random = new Random();
            //StringBuilder sb = new StringBuilder();
            //StringReader reader = new StringReader(pool);
            char[] passwordGen = new char[charLength];
            for (int i = 0; i < charLength; i++)
            {
                passwordGen[i] = pool[random.Next() % pool.Length];
            }
            password = new string(passwordGen);
            DisplayAlert("Hasło", password, "OK");
        }
    }

}
