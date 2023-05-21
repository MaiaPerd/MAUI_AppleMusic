namespace MAUI_TP1_AppleMusic.Views;

public partial class BouttonView : ContentView
{
    public static readonly BindableProperty ImageNomProperty = BindableProperty.Create(nameof(ImageNom), typeof(string), typeof(BouttonView), string.Empty);
    public static readonly BindableProperty NomProperty = BindableProperty.Create(nameof(Nom), typeof(string), typeof(BouttonView), string.Empty);

    public string ImageNom
    {
        get => (string)GetValue(BouttonView.ImageNomProperty);
        set => SetValue(BouttonView.ImageNomProperty, value);
    }

    public string Nom
    {
        get => (string)GetValue(BouttonView.NomProperty);
        set => SetValue(BouttonView.NomProperty, value);
    }

    public BouttonView()
	{
		InitializeComponent();
        BindingContext = this;
	}
}
