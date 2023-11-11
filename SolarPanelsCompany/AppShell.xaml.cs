using SolarPanelsCompany.Views;

namespace SolarPanelsCompany
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("login", typeof(Login));
            Routing.RegisterRoute("home", typeof(Home));
            Routing.RegisterRoute("details", typeof(Details));
        }

    }
}