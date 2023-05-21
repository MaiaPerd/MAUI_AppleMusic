namespace MAUI_TP1_AppleMusic.Views;

public partial class MusicDetailView : ContentView
{
    public static readonly BindableProperty NomProperty = BindableProperty.Create(nameof(Nom), typeof(string), typeof(MusicDetailView), "null");
    
    public string Nom
    {
        get => (string)GetValue(MusicDetailView.NomProperty);
        set => SetValue(MusicDetailView.NomProperty, value);
    }

    public static readonly BindableProperty NumeroProperty = BindableProperty.Create(nameof(Numero), typeof(int), typeof(MusicDetailView), 0);

    public int Numero
    {
        get => (int)GetValue(MusicDetailView.NumeroProperty);
        set => SetValue(MusicDetailView.NumeroProperty, value);
    }

    public MusicDetailView()
	{
		InitializeComponent();
    }
}
