namespace AsyncUIExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateToSlowPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("slow");
        }
    }

}
