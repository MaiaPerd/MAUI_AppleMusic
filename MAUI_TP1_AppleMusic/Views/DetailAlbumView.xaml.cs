namespace MAUI_TP1_AppleMusic.Views;

public partial class DetailAlbumView : ContentView
{
	public DetailAlbumView()
	{
		InitializeComponent();
	}

	public string Titre
	{
		get => titre;
		set
		{
			titre = value;
		
		}
	}
	private string titre;
}