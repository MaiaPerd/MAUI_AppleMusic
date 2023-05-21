using System.Collections.ObjectModel;
using MAUI_TP1_AppleMusic.Models;
using MAUI_TP1_AppleMusic.Stub;

namespace MAUI_TP1_AppleMusic.Views;

public partial class MusicListView : ContentView
{
    public ObservableCollection<Musique> Musiques { get; private set; } = new ObservableCollection<Musique>(AlbumStub.getMusiqueList());

    public MusicListView()
	{
		InitializeComponent();
        BindingContext = this;
    }
}
