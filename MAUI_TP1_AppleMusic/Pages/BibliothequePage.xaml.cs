namespace MAUI_TP1_AppleMusic.Pages;

public partial class BibliothequePage : ContentPage
{
	public BibliothequePage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new AlbumPage());
    }
}
