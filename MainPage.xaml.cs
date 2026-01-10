namespace EgzaminProbny6MobileApp
{
    public partial class MainPage : ContentPage
    {
        private static int likeCount;
        public MainPage()
        {
            likeCount = 0;
            InitializeComponent();
        }
        private void onBtnLikeClicked(object sender, EventArgs e)
        {
            likeCount++;
            lblLikes.Text = (likeCount.ToString()+" Polubień");
        }
        private void onBtnDeletClicked(object sender, EventArgs e)
        {
            if (likeCount != 0) likeCount--;
            lblLikes.Text = (likeCount.ToString() + " Polubień");
        }
    }

}
