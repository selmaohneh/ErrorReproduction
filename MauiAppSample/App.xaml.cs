using MauiAppSample.Core;
using IView = MauiAppSample.Core.IView;

namespace MauiAppSample;

public partial class App : Application, IViewNavigator
{
    public App()
    {
        var pageA = new MainPage() { BackgroundColor = Colors.Red };
        var pageB = new MainPage() { BackgroundColor = Colors.Green };
        var root = new Root(pageA, pageB, this);

        InitializeComponent();

        root.StartApplication();
    }

    public void ShowView(IView view)
    {
        var page = (Page)view;
        MainPage = page;
    }
}