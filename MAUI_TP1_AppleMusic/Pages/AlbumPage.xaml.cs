using MAUI_TP1_AppleMusic.Models;

namespace MAUI_TP1_AppleMusic.Pages;

public partial class AlbumPage : ContentPage
{
    public static readonly BindableProperty AlbumProperty = BindableProperty.Create(nameof(Album), typeof(Album), typeof(AlbumPage), (Application.Current as App).CurrentAlbum);

    public Album Album
    {
        get => (Album)GetValue(AlbumPage.AlbumProperty);
        set => SetValue(AlbumPage.AlbumProperty, value);
    }

    public AlbumPage()
	{
		InitializeComponent();
        BindingContext = this;
        // <BackButtonBehavior TextOverride="bibliothèque"></BackButtonBehavior>
    }

}