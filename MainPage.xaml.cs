using Microsoft.Maui.Controls.PlatformConfiguration;
using System.Xml.Linq;
using Windows.Storage;
using Windows.Storage.Pickers;
using WinRT.Interop;
using static System.Net.Mime.MediaTypeNames;

namespace EgzaminProbny10MobileApp
{
    public partial class MainPage : ContentPage
    {
        string encryptedText;
        public string encrypt(string publicText, int key)
        {
            key = key % 26;
            string encryptedText = publicText;
            if (key != 0)
            {
                char[] encryptedTextAsChar = new char[publicText.Length];
                for (int i = 0; i < publicText.Length; i++)
                {
                    if (publicText[i] == ' ') { encryptedTextAsChar[i] = ' '; continue; }
                    encryptedTextAsChar[i] = Convert.ToChar(Convert.ToInt32(publicText[i]) + key);
                    if ((Convert.ToInt32(publicText[i]) + key) > 122)
                    {
                        encryptedTextAsChar[i] = Convert.ToChar((Convert.ToInt32(publicText[i]) + key) % 122 + 96);
                    }
                    if ((Convert.ToInt32(publicText[i]) + key) < 97)
                    {
                        encryptedTextAsChar[i] = Convert.ToChar(
                            122 + Convert.ToInt32(publicText[i]) % 96 + key
                            );
                        Console.WriteLine(Convert.ToInt32(publicText[i]) % 96 + key);
                    }
                }
                encryptedText = new string(encryptedTextAsChar);
            }
            return encryptedText;
        }
        private void OnCypherClicked(object sender, EventArgs e)
        {
            string text = entText.Text;
            string keyCheck = entKey.Text;
            int key = 0;
            if(Convert.ToInt32(entKey.Text) != null) key = Convert.ToInt32(entKey.Text);
            //if (keyCheck[0] == '-')
            //for (int i = 1; i > keyCheck.Length; i++)
            //    {
            //        if (!Char.IsDigit(entKey.Text[i])) break;
            //        else key = Convert.ToInt32(entKey.Text);
            //    }
            //else
            //    for (int i = 0; i > keyCheck.Length; i++)
            //    {
            //        if (!Char.IsDigit(entKey.Text[i])) break;
            //        else key = Convert.ToInt32(entKey.Text);
            //    }
            encryptedText = encrypt(text, key);
            lblEncryptedText.Text = encryptedText;
            
        }
        private async void onSaveClicked(object sender, EventArgs e)
        {
            FileSavePicker picker = new FileSavePicker();
            picker.SuggestedFileName = "plik";
            //picker.FileTypeChoices.Add("Tekst", new[] { ".txt" });
            //picker.FileTypeChoices.Add("Tekst");
            var hwnd = WindowNative.GetWindowHandle(App.Current.Windows[0].Handler.PlatformView);
            InitializeWithWindow.Initialize(picker, hwnd);

            var file = await picker.PickSaveFileAsync();
            if (file != null)
            {
                await FileIO.WriteTextAsync(file, encryptedText);
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

    }

}
