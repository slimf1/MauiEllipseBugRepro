namespace MauiApp2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        await Ellipse.ScaleTo(0.5, 1000);
    }
}