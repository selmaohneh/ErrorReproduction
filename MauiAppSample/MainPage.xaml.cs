namespace MauiAppSample;

public partial class MainPage : ContentPage, Core.IView
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ButtonClicked(object sender, EventArgs e)
    {
        TheSampleButtonWasClicked?.Invoke(this, EventArgs.Empty);
    }

    public event EventHandler TheSampleButtonWasClicked;
}