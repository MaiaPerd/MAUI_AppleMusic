using MAUI_TP1_AppleMusic.Models;
using MAUI_TP1_AppleMusic.Stub;

namespace MAUI_TP1_AppleMusic.Views;

public partial class MusicListView : ContentView
{
	public List<Album> Albums = AlbumStub.getAlbumList();

    public MusicListView()
	{
		InitializeComponent();
	}
}
