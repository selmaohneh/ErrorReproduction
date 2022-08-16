namespace MauiAppSample.Core
{
    public interface IView
    {
        event EventHandler TheSampleButtonWasClicked;
    }

    public interface IViewNavigator
    {
        void ShowView(IView view);
    }
}
