namespace rtoasaS3r
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Page1());
        }
    }
}
