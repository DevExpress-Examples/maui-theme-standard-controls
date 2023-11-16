namespace DXMaterialThemesApp;

public partial class MainPage : ContentPage {
    private ThemesPage themesPage = new ThemesPage();
    
    public MainPage() {
        InitializeComponent();
    }

    private async void Palette_Clicked(object sender, EventArgs e) {
        await Navigation.PushAsync(themesPage);
    }
}