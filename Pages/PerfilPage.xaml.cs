namespace BogoMaps.Pages;

public partial class PerfilPage : ContentPage
{
    public PerfilPage()
    {
        InitializeComponent();
    }

    private async void OnCerrarSesionClicked(object? sender, EventArgs e) => await Shell.Current.GoToAsync("//login");

    private static Color Res(string key) => (Color)Application.Current!.Resources[key];

    private void OnTabClicked(object? sender, EventArgs e)
    {
        if (sender is not Button pressed)
            return;

        foreach (var tab in new[] { TabActivos, TabResueltos, TabGuardados })
        {
            var selected = tab == pressed;
            tab.BackgroundColor = selected ? Res("SurfaceLowest") : Colors.Transparent;
            tab.TextColor = Res(selected ? "OnSurface" : "OnSurfaceVariant");
        }
    }
}
