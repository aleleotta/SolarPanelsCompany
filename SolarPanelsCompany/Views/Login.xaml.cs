namespace SolarPanelsCompany.Views;

public partial class Login : ContentPage
{

    public Login()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        const String username = "aleleotta";
        const String password = "fakePassword2023";
        if (usernameField.Text == username && passwordField.Text == password)
        {
            usernameField.Text = "";
            passwordField.Text = "";
            await Navigation.PushModalAsync(new Home());
        }
        else {
            usernameField.Text = "";
            passwordField.Text = "";
            await DisplayAlert("Error", "The username or password is incorrect.", "Close");
        }
    }
}