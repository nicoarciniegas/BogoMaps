namespace BogoMaps.Pages;

public partial class PerfilPage : ContentPage
{
    public PerfilPage()
    {
        InitializeComponent();
    }

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
