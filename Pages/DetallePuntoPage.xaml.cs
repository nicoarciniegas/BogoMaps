namespace BogoMaps.Pages;

public partial class DetallePuntoPage : ContentPage
{
    private bool _guardado;

    public DetallePuntoPage()
    {
        InitializeComponent();
    }

    private void OnGuardarClicked(object? sender, EventArgs e)
    {
        _guardado = !_guardado;
        GuardarBtn.Text = _guardado ? "\U0001F516 Guardado" : "\U0001F516 Guardar";
    }

    private async void OnConfirmarClicked(object? sender, EventArgs e)
    {
        ConfirmarBtn.IsEnabled = false;
        await DisplayAlert("¡Gracias, vecino!", "Tu aporte ayuda a mantener Bogotá caminable.", "OK");
    }

    private async void OnReportarCambioClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//reportar");
    }
}
