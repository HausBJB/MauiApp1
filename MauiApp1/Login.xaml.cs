namespace MauiApp1;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(MainPage));
	}
}