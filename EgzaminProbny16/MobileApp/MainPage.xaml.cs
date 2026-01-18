namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        int r, g, b;
        public MainPage()
        {
            InitializeComponent();
        }
        private void onDownloadClicked(object sender, EventArgs e)
        {
            lblRGBs.Text = r.ToString() + ", " + g.ToString() + ", " + b.ToString();
            lblRGBs.BackgroundColor = Color.FromRgb(r, g, b);
            colorDisplayBlock.BackgroundColor = Color.FromRgb(r, g, b);
        }
        
        private void OnSliderValueChanged(object sender, EventArgs e)
        {
            Slider slider = (Slider)sender;
            switch (slider.ClassId)
            {
                case "R":
                    r = Convert.ToInt32(slider.Value);
                    lblRDysplay.Text = r.ToString();
                    break;
                case "G":
                    g = Convert.ToInt32(slider.Value);
                    lblGDysplay.Text = g.ToString();
                    break;
                case "B":
                    b = Convert.ToInt32(slider.Value);
                    lblBDysplay.Text = b.ToString();
                    break;
            }
        }
    }

}
