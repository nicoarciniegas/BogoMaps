namespace BogoMaps.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnToggleClave(object? sender, EventArgs e)
    {
        ClaveEntry.IsPassword = !ClaveEntry.IsPassword;
        MostrarClaveButton.Text = ClaveEntry.IsPassword ? "Ver" : "Ocultar";
    }

    private async void OnLoginClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//explorar");
    }

    private async void OnInvitadoTapped(object? sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//explorar");
    }
}
