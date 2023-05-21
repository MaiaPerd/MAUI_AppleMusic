using System.Collections.ObjectModel;
using MAUI_TP1_AppleMusic.Models;
using MAUI_TP1_AppleMusic.Stub;

namespace MAUI_TP1_AppleMusic.Views;

public partial class CategoriesListView : ContentView
{
    public ObservableCollection<Catgerorie> Categories { get; private set; } = new ObservableCollection<Catgerorie>(AlbumStub.getCategList());

    public CategoriesListView()
	{
		InitializeComponent();
        BindingContext = this;
    }
}
