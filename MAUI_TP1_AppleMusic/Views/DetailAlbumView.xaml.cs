namespace MAUI_TP1_AppleMusic.Views;

public partial class DetailAlbumView : ContentView
{
    public static readonly BindableProperty NomProperty = BindableProperty.Create(nameof(Nom), typeof(string), typeof(DetailAlbumView), "null");

    public string Nom
    {
        get => (string)GetValue(DetailAlbumView.NomProperty);
        set => SetValue(DetailAlbumView.NomProperty, value);
    }

    public static readonly BindableProperty AuteurProperty = BindableProperty.Create(nameof(Auteur), typeof(string), typeof(DetailAlbumView), "null");

    public string Auteur
    {
        get => (string)GetValue(DetailAlbumView.AuteurProperty);
        set => SetValue(DetailAlbumView.AuteurProperty, value);
    }

    public static readonly BindableProperty AnneeProperty = BindableProperty.Create(nameof(Annee), typeof(int), typeof(DetailAlbumView), 0);

    public int Annee
    {
        get => (int)GetValue(DetailAlbumView.AnneeProperty);
        set => SetValue(DetailAlbumView.AnneeProperty, value);
    }

    public static readonly BindableProperty ImageNameProperty = BindableProperty.Create(nameof(ImageName), typeof(string), typeof(DetailAlbumView), "on_the_tender_spot.png");

    public string ImageName
    {
        get => (string)GetValue(DetailAlbumView.ImageNameProperty);
        set => SetValue(DetailAlbumView.ImageNameProperty, value);
    }


    public DetailAlbumView()
	{
		InitializeComponent();
        BindingContext = this;
    }
}