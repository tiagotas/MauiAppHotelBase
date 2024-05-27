namespace MauiAppHotel.Views;

public partial class HospedagemCalculada : ContentPage
{
	public HospedagemCalculada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}