namespace BogoMaps.Pages;

public partial class ReportarPage : ContentPage
{
    public ReportarPage()
    {
        InitializeComponent();
    }

    private static Color Res(string key) => (Color)Application.Current!.Resources[key];

    private void OnCategoriaTapped(object? sender, TappedEventArgs e)
    {
        if (sender is not Border tapped)
            return;

        foreach (var child in CategoriaGrid.Children.OfType<Border>())
        {
            var selected = child == tapped;
            child.BackgroundColor = Res(selected ? "BrandPrimary" : "SurfaceLow");
            if (child.Content is Label label)
                label.TextColor = selected ? Colors.White : Res("OnSurface");
        }
    }

    private void OnGravedadClicked(object? sender, EventArgs e)
    {
        if (sender is not Button pressed)
            return;

        foreach (var btn in new[] { BtnBajo, BtnModerado, BtnCritico })
        {
            btn.BackgroundColor = Colors.Transparent;
            btn.TextColor = Res("OnSurfaceVariant");
        }

        if (pressed == BtnBajo)
        {
            pressed.BackgroundColor = Res("SecondaryContainer");
            pressed.TextColor = Res("OnSecondaryContainer");
            GravedadLabel.Text = "Bajo";
            GravedadLabel.TextColor = Res("BrandSecondary");
        }
        else if (pressed == BtnModerado)
        {
            pressed.BackgroundColor = Res("TertiaryFixed");
            pressed.TextColor = Res("OnTertiaryFixed");
            GravedadLabel.Text = "Moderado";
            GravedadLabel.TextColor = Res("TertiaryContainer");
        }
        else
        {
            pressed.BackgroundColor = Res("ErrorContainer");
            pressed.TextColor = Res("OnErrorContainer");
            GravedadLabel.Text = "Crítico";
            GravedadLabel.TextColor = Res("BrandError");
        }
    }

    private async void OnGpsClicked(object? sender, EventArgs e)
    {
        await DisplayAlert("GPS", "Pendiente: obtener la ubicación actual del dispositivo.", "OK");
    }

    private async void OnFotoClicked(object? sender, EventArgs e)
    {
        await DisplayAlert("Foto", "Pendiente: captura de foto con MediaPicker.", "OK");
    }

    private async void OnPublicarClicked(object? sender, EventArgs e)
    {
        PublicarBtn.IsEnabled = false;
        PublicarBtn.Text = "Publicando reporte...";
        await Task.Delay(900);
        PublicarBtn.BackgroundColor = Res("BrandSecondary");
        PublicarBtn.Text = "¡Reporte Registrado!";
    }
}
