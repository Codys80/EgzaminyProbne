namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        string[] message = { "Dzień dobry", "Good morning", "Buenos dias" };
        int msgIndex = 0;
        int fontSize = 0;
        public MainPage()
        {
            InitializeComponent();
            lblMsgDisplay.Text = message[msgIndex];
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (msgIndex == 2) msgIndex = 0;
            else msgIndex++;
            lblMsgDisplay.Text = message[msgIndex];
        }
        private void onValueChanged(object sender, EventArgs e)
        {
            fontSize = Convert.ToInt32( sldFontSize.Value);
            lblMsgDisplay.FontSize = fontSize;
            lblSizeDisplay.Text = "Rozmiar: " + fontSize.ToString();
        }
    }

}
