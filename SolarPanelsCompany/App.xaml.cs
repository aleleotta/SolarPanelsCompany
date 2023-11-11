using SolarPanelsCompany.Views;

namespace SolarPanelsCompany
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Home();
        }
    }
}