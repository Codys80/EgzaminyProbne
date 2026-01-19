namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        int age = 0;
        List<string > lista = new List<string>();
        string selectedAnimal;
        TimeSpan time;
        public MainPage()
        {
            InitializeComponent();
            lista.Add("Pies");
            lista.Add("Kot");
            lista.Add("Świnka morska");
            listView1.ItemsSource = lista;
        }

        private void OnOkClicked(object sender, EventArgs e)
        {
            time = timePicker.Time; 
            string msg = entOwnerName.Text + " " + selectedAnimal + " " + 
                         age.ToString() + " " + entPurpose.Text + " " + time.ToString();
            DisplayAlert("Zapisana wizyta", msg ,"ok");
        }
        private void onItenSelected(object sender, EventArgs e)
        {
            selectedAnimal = listView1.SelectedItem.ToString();
        }
        private void onSliderChange(object sender, EventArgs e)
        {
            age = Convert.ToInt32( sldAge.Value );
            lblYearDisplay.Text = "Ile ma lat? "+ age.ToString();
        }
    }

}
