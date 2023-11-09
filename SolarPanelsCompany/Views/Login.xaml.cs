namespace SolarPanelsCompany.Views;

public partial class Login : ContentPage
{

    public const String username = "aleleotta";
    public const String password = "fakePassword2023";

    public Login()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (usernameField.Text == username && passwordField.Text == password)
        {
            usernameField.Text = "";
            passwordField.Text = "";
            await Navigation.PushModalAsync(new Home(), true);
        }
        else {
            usernameField.Text = "";
            passwordField.Text = "";
            await DisplayAlert("Error", "The username or password is incorrect.", "Close");
        }
    }
}