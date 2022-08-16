namespace MauiAppSample.Core
{
    public class PageAPresenter
    {
        private readonly IView _pageB;
        private readonly IViewNavigator _viewNavigator;
        public IView PageA { get; }

        public PageAPresenter(IView pageA, IView pageB, IViewNavigator viewNavigator)
        {
            _pageB = pageB;
            _viewNavigator = viewNavigator;
            PageA = pageA;
            pageA.TheSampleButtonWasClicked += OnTheSampleButtonWasClicked;
        }

        private void OnTheSampleButtonWasClicked(object? sender, EventArgs e)
        {
            _viewNavigator.ShowView(_pageB);
        }
    }
}