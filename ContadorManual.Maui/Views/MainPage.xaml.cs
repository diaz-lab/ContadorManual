using ContadorManual.Maui.Models;
namespace ContadorManual.Maui.Views;

public partial class MainPage : ContentPage
{
    private Contador _contador;
	public MainPage()
	{
		InitializeComponent();
        _contador = new Contador();
        ConteoLabel.Text = _contador.Conteo.ToString();
	}

    private void OnContarButton_Clicked(object sender, EventArgs e)
    {
        _contador.Contar();
        ConteoLabel.Text = _contador.Conteo.ToString();
    }

    private void OnReiniciarButton_Clicked(object sender, EventArgs e)
    {
        _contador.Reiniciar();
        ConteoLabel.Text = _contador.Conteo.ToString();
    }
}