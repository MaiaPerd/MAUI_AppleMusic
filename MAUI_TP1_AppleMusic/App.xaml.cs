using System.Collections.ObjectModel;
using MAUI_TP1_AppleMusic.Models;
using MAUI_TP1_AppleMusic.Stub;

namespace MAUI_TP1_AppleMusic;

public partial class App : Application
{
    public Album CurrentAlbum { get; set; } = AlbumStub.getAlbum();


    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

