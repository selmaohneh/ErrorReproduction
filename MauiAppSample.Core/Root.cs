namespace MauiAppSample.Core
{
    public class Root
    {
        private readonly IView _pageA;
        private readonly IView _pageB;
        private readonly IViewNavigator _viewNavigator;

        public Root(IView pageA, IView pageB, IViewNavigator viewNavigator)
        {
            _pageA = pageA;
            _pageB = pageB;
            _viewNavigator = viewNavigator;

            var presenterA = new PageAPresenter(pageA, pageB, _viewNavigator);
            var presenterB = new PageBPresenter(pageB, pageA, _viewNavigator);
        }

        public void StartApplication()
        {
            _viewNavigator.ShowView(_pageA);
        }
    }
}
