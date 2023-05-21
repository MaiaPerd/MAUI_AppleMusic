using System.Collections.ObjectModel;
using MAUI_TP1_AppleMusic.Models;
using MAUI_TP1_AppleMusic.Pages;
using MAUI_TP1_AppleMusic.Stub;

namespace MAUI_TP1_AppleMusic.Views;

public partial class AlbumElementGridView : ContentView
{
    public ObservableCollection<Album> Albums { get; private set; } = new ObservableCollection<Album>(AlbumStub.getAlbumList());

    public AlbumElementGridView()
    {
        InitializeComponent();
        BindingContext = this;
    }

    async void Button_tap(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new AlbumPage());
    }

    async void OnTapGestureRecognizerTapped(System.Object sender, System.EventArgs e)
    {
        VerticalStackLayout tap = (VerticalStackLayout)sender;
        var item = (TapGestureRecognizer)tap.GestureRecognizers[0];
        Album album = (Album)item.CommandParameter;
        var currentApp = (Application.Current as App);
        currentApp.CurrentAlbum = album;
        await Navigation.PushAsync(new AlbumPage());
    }
}
