namespace BogoMaps.Pages;

public partial class ExplorarPage : ContentPage
{
    public ExplorarPage()
    {
        InitializeComponent();
    }

    private void OnChipTapped(object? sender, TappedEventArgs e)
    {
        if (sender is not Border tapped || tapped.Parent is not HorizontalStackLayout row)
            return;

        foreach (var child in row.Children.OfType<Border>())
        {
            var selected = child == tapped;
            child.BackgroundColor = (Color)Application.Current!.Resources[selected ? "BrandPrimary" : "SurfaceLowest"];
            if (child.Content is Label label)
                label.TextColor = selected ? Colors.White : (Color)Application.Current.Resources["OnSurface"];
        }
    }

    private async void OnNearMeClicked(object? sender, EventArgs e)
    {
        await DisplayAlert("Cerca de mí", "Aquí se centrará el mapa en tu ubicación.", "OK");
    }

    private async void OnConfirmClicked(object? sender, EventArgs e)
    {
        await DisplayAlert("¡Gracias, vecino!", "Tu aporte ayuda a mantener Bogotá caminable.", "OK");
    }
}
