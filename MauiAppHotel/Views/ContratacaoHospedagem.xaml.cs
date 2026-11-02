namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void btn_sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Sobre());
    }
}